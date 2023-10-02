using System;
using System.Collections.Generic;
using System.Linq;

namespace Movies
{
    internal class MovieMember : MembersSystem, IMembers
    {
        private static int lastID = 0;
        private List<MembersSystem> members;
        public MovieMember()
        {
            Id = lastID++;
            members = new List<MembersSystem>()
            {
                new MembersSystem() {Name = "lado", LastName = "bartia", Password = "123", Id = 1, Mail = "bartialado@gmail.com", RegistrationData = DateTime.Now},
                new MembersSystem() {Name = "papuna", LastName = "bartia", Password = "1234", Id = 2, Mail = "bartiapapuna@gmail.com", RegistrationData = DateTime.Now},
                new MembersSystem() {Name = "akula", LastName = "galdava", Password = "1235", Id = 3, Mail = "galdavaakula@gmail.com", RegistrationData = DateTime.Now}
            };      
        }
        public void RecoveryInformation(string name, MembersSystem upDateMember)
        {
            try
            {
                MembersSystem recoveryMember = members.FirstOrDefault(x => x.Name == name);
                if (recoveryMember != null)
                {
                    recoveryMember.Password = upDateMember.Password;                
                    Console.WriteLine("Successfully updated");              
                }
                else
                {
                    Console.WriteLine("User not found!");
                }
            }
            catch (Exception)
            {
                throw;
            }         
        }
        public bool Login(string logName, string password)
        {
            try
            {
                MembersSystem member = members.FirstOrDefault(m => m.Name == logName && m.Password == password);
                return member != null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Print()
        {
            foreach (var item in members)
            {
                Console.WriteLine(item);
                Console.WriteLine("------------");
            }
        }
        public void Registration(MembersSystem member)
        {
            try
            {
                if (members.Any(user => user.Name == member.Name && user.Password == member.Password))
                {
                    Console.WriteLine("Username or password already exists!!!");
                }
                else
                {
                    members.Add(member);
                    Console.WriteLine("Registred successfully");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void RemoveMember(int memberId)
        {
            try
            {
                MembersSystem removeMember = members.Find(x => x.Id == memberId);
                members.Remove(removeMember);
                Console.WriteLine("Member removed successfully");
            }
            catch (Exception)
            {
                throw;
            }          
        }
        public List<MembersSystem> Search(string memberName)
        {
            try
            {
                return members.Where(x => x.Name == memberName).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
