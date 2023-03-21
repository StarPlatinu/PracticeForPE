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
        public void DeleteMember(Member member) => MemberDao.Instance.Remove(member);

        public Member GetMemberById(int id) =>MemberDao.Instance.GetMemberById(id);

        public IEnumerable<Member> GetMembers() =>MemberDao.Instance.GetMemberList();

        public void InsertMember(Member member) => MemberDao.Instance.Insert(member);

        public void UpdateMember(Member member) => MemberDao.Instance.Update(member);
    }
}
