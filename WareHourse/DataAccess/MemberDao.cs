using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MemberDao
    {
        private static MemberDao instance = null;
        private static readonly object instanceLock = new object();
        private MemberDao() { }
        public static MemberDao Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new MemberDao();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Member> GetMemberList()
        {
            List<Member> members;
            try
            {
                var myDB = new ShopingMiniContext();
                members = myDB.Members.ToList();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }

        public Member GetMemberById(int id)
        {
            Member member= null;
            try
            {
                var myDb = new ShopingMiniContext();
                member = myDb.Members.SingleOrDefault(member => member.MemberId == id);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public void Insert(Member member)
        {
            try
            {
                Member _member = GetMemberById(member.MemberId);
                if(_member == null)
                {
                    var myDb = new ShopingMiniContext();
                    myDb.Members.Add(member);
                    myDb.SaveChanges();
                }
                else
                {
                    throw new Exception("The member already exist.");
                }
            }catch(Exception ex) { 
            throw new Exception(ex.Message);
            }
        }

        public void Update(Member member)
        {
            try
            {
                Member _member= GetMemberById(member.MemberId);
                if(_member != null)
                {
                    var myDb = new ShopingMiniContext();
                    myDb.Entry<Member>(member).State = EntityState.Modified;
                    myDb.SaveChanges();
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(Member member)
        {
            try
            {
                Member _member = GetMemberById(member.MemberId);
                if (_member != null)
                {

                    var myDb = new ShopingMiniContext();
                    myDb.Members.Remove(member);
                    myDb.SaveChanges();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
