using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
	public class MemberRepository : IMemberRepository
	{

		public MemberObject GetMemberById(int id) => MemberDAO.Instance.GetMemberById(id);

		public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList();

		public void AddNewMember(MemberObject member) => MemberDAO.Instance.AddNewMember(member);
		public void UpdateMember(MemberObject member) => MemberDAO.Instance.UpdateMember(member);
		public void DeleteMember(int memberId) => MemberDAO.Instance.DeleteMember(memberId);
	}
}
