using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public IEnumerable<MemberObject> GetMembers();
        public MemberObject GetMemberById(int id);
        public void AddNewMember(MemberObject member);
        public void DeleteMember(int id);
        public void UpdateMember(MemberObject member);

    }
}
