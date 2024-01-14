using Azure.Core;
using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLook = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get{
                lock(instanceLook) {
                    if(instance == null) { instance = new MemberDAO(); }
                }
                return instance;
            }
        }

        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader? reader = null;
            string sqlSelect = "Select MemberId,Email,CompanyName,City,Country,Password from Member";
            var members = new List<MemberObject>();
            try
            {
                reader = Provider.GetDataReader(sqlSelect, CommandType.Text, out Connection);
                while (reader.Read()) {
                    members.Add(new MemberObject
                    {
                        MemberId = reader.GetInt32(0),
                        Email = reader.GetString(1),
                        CompanyName = reader.GetString(2),
                        City = reader.GetString(3),
                        Country = reader.GetString(4),
                        Password = reader.GetString(5)
                    }); 
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return members;
        }

        public MemberObject GetMemberById(int id)
        {
            MemberObject member = null;
            IDataReader? dataReader = null;
            string sqlQuery = "Select MemberId,Email,CompanyName,City,Country,Password from Member where MemberId = @id";
            try
            {
                var param = Provider.CreateParameter("@id", 4, id, DbType.Int32);
                dataReader = Provider.GetDataReader(sqlQuery,CommandType.Text,out Connection, param); 
                if(dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    };
                }
            }
            catch(Exception ex) {
                throw new Exception(ex.Message);
            }
            finally {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }
        public void AddNewMember(MemberObject member)
        {
            try
            {
                MemberObject newMember = GetMemberById(member.MemberId);
                if(newMember == null) {
                    string sqlQuery = "Insert Member values (@MemberId,@Email,@CompanyName,@City,@Country,@Password)";
                    var parameters  = new List<SqlParameter>();
                    parameters.Add(Provider.CreateParameter("@MemberId",4,member.MemberId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@Email",100,member.Email, DbType.String));
                    parameters.Add(Provider.CreateParameter("@CompanyName",40,member.CompanyName, DbType.String));
                    parameters.Add(Provider.CreateParameter("City",15,member.City, DbType.String));
                    parameters.Add(Provider.CreateParameter("@Country",15,member.Country, DbType.String));
                    parameters.Add(Provider.CreateParameter("Password",30,member.Password, DbType.String));
                    Provider.Insert(sqlQuery,CommandType.Text,parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Member has been exists");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        //----------------------------------------------------------------------------
        public void UpdateMember(MemberObject member)
        {
            try
            {
                MemberObject newMember = GetMemberById(member.MemberId);
                if (newMember != null)
                {
                    string sqlQuery = "Update Member " +
                        " set Email = @Email, CompanyName = @CompanyName, City = @City, Country = @Country, Password = @Password" +
                        " Where MemberId = @MemberId";
                    
                    var parameters = new List<SqlParameter>();
                    parameters.Add(Provider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32));
                    parameters.Add(Provider.CreateParameter("@Email", 100, member.Email, DbType.String));
                    parameters.Add(Provider.CreateParameter("@CompanyName", 40, member.CompanyName, DbType.String));
                    parameters.Add(Provider.CreateParameter("City", 15, member.City, DbType.String));
                    parameters.Add(Provider.CreateParameter("@Country", 15, member.Country, DbType.String));
                    parameters.Add(Provider.CreateParameter("Password", 30, member.Password, DbType.String));
                    Provider.Update(sqlQuery, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Member has not been exits");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        //-------------------------------------------------------------------------
        public void DeleteMember(int memberId)
        {
            try
            {
                MemberObject member = GetMemberById(memberId);
                if(member != null){
                    string sqlQuery = "Delete Member where MemberId = @MemberId";
                    var param = Provider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32);
                    Provider.Delete(sqlQuery, CommandType.Text, param);
                }
                else { throw new Exception("This Member has not been exits"); }

            }
            catch(Exception ex) { throw new Exception(ex.Message); }
            finally { Connection.Close(); }
        }
    }
}