using InfoServiceDataLayer.Models.Interfaces;
using InfoServiceDataLayer.Repositories.Interfaces;
using InfoServiceDataLayer.SqlHelper.Implementations;
using InfoServiceDataLayer.SqlHelper.Interfaces;
using Microsoft.DataClient.Tools;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace InfoServiceDataLayer.Repositories.Implementations
{
    public class UserRepository : BaseRepository, IUserRepository
    { 
        public UserRepository(IOptions<DatabaseSettings> options) : base(options)
        {

        }

        public List<IUser> Get(int idUser)
        {
            var response = new List<IUser>();

            var parameters = new[] { 
                new SqlParameter("@IdUser", idUser)
            };

            using (SqlDataReader reader = Microsoft.DataClient.Tools.SqlHelper.ExecuteReader(_databaseSettings.ConnectionString, "usp_User_sel", parameters))
            {
                while(reader.Read())
                {
                    response.Add(LoadUserFromDatabaseWithReader(reader));
                }

                return response;
            }
        }

        public int Insert(IUser newUser)
        {
            var parameters = new[] {
                //new SqlParameter("@Iduser", newUser.Iduser),
                new SqlParameter("@Firstname", newUser.Firstname),
                new SqlParameter("@Surname", newUser.Surname),
                new SqlParameter("@Passwordhash", newUser.Passwordhash),
                new SqlParameter("@Status", newUser.Status),
                new SqlParameter("@Username", newUser.Username),
                //new SqlParameter("@Datecreatedutc", newUser.Datecreatedutc),
                //new SqlParameter("@Datemodifiedutc", newUser.Datemodifiedutc),
            };

            return (int)Microsoft.DataClient.Tools.SqlHelper.ExecuteScalar(_databaseSettings.ConnectionString, "usp_User_ins", parameters);
        }

        public bool Update(IUser newUser)
        {
            var parameters = new[] {
                new SqlParameter("@Iduser", newUser.Iduser),
                new SqlParameter("@Firstname", newUser.Firstname),
                new SqlParameter("@Surname", newUser.Surname),
                new SqlParameter("@Passwordhash", newUser.Passwordhash),
                new SqlParameter("@Status", newUser.Status),
                new SqlParameter("@Username", newUser.Username),
                //new SqlParameter("@Datecreatedutc", newUser.Datecreatedutc),
                //new SqlParameter("@Datemodifiedutc", newUser.Datemodifiedutc),
            };

            return (bool)Microsoft.DataClient.Tools.SqlHelper.ExecuteScalar(_databaseSettings.ConnectionString, "usp_User_upd", parameters);
        }

        IUser LoadUserFromDatabaseWithReader(SqlDataReader reader)
        {
            return new Models.Implementations.User()
            {
                Iduser = (int)reader[reader.GetOrdinal("Iduser")],

                Firstname = (string)reader[reader.GetOrdinal("Firstname")],
                Surname = (string)reader[reader.GetOrdinal("Surname")],

                Passwordhash = (string)reader[reader.GetOrdinal("Passwordhash")],
                Status = (sbyte)reader[reader.GetOrdinal("Status")],

                Username = (string)reader[reader.GetOrdinal("Username")],

                Datecreatedutc = (DateTime)reader[reader.GetOrdinal("Datecreatedutc")],
                Datemodifiedutc = (DateTime)reader[reader.GetOrdinal("Datemodifiedutc")],
            };
        }
    }
}
