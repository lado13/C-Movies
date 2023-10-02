using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Movies
{
    internal class AppMenu
    {


        public static void WatchMovie()
        {
            Console.WriteLine("Print Movie(1)\nSearch Movie(2)\nAdd Movie(3)\nRemove movie(4)\nEdit movie(5)\n------------------\nMember registration(6)\nPrint member(7)\nRemove member(8)\nSearch member(9)\nLogin(10)");
            MovieLibrary movieLibrary = new MovieLibrary();
            MovieMember movieMember = new MovieMember();
            



            while (true)
            {

                switch (Console.ReadLine())
                {
                    case "1":
                        movieLibrary.PrintMovie();
                        break;
                    case "2":
                        string searchMovie = Console.ReadLine();
                        var res = movieLibrary.SearchMovie(searchMovie);

                        foreach (var item in res)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "3":
                        MovieSystem newMovie = new MovieSystem();

                        Console.Write("Enter title: ");
                        newMovie.Title = Console.ReadLine();

                        Console.Write("Enter date of shooting: ");
                        newMovie.DateOfShooting = DateTime.Parse(Console.ReadLine());

                        Console.Write("Enter director name: ");
                        newMovie.Director = Console.ReadLine();

                        Console.Write("Enter genre: ");
                        newMovie.Genre = Console.ReadLine();

                        Console.Write("Enter nationality: ");
                        newMovie.Nationality = Console.ReadLine();

                        Console.Write("Enter IMDB: ");
                        newMovie.IMDB = int.Parse(Console.ReadLine());

                        movieLibrary.AddMovie(newMovie);

                        break;
                    case "4":
                        Console.Write("Enter the title remove: ");
                        string removeMovie = Console.ReadLine();

                        movieLibrary.RemoveMovie(removeMovie);
                        break;
                    case "5":

                        MovieSystem editMovie = new MovieSystem();
                        Console.Write("Enter edited title: ");
                        string editebleMovieTitle = Console.ReadLine();

                        Console.Write("Enter new title: ");
                        editMovie.Title = Console.ReadLine().ToUpper();

                        Console.Write("Enter edited date of shooting: ");
                        editMovie.DateOfShooting = DateTime.Parse(Console.ReadLine());

                        Console.Write("Enter director name: ");
                        editMovie.Director = Console.ReadLine().ToUpper();

                        Console.Write("Enter IMDB: ");
                        editMovie.IMDB = int.Parse(Console.ReadLine());

                        Console.Write("Enter nationality: ");
                        editMovie.Nationality = Console.ReadLine();

                        Console.Write("Enter genre: ");
                        editMovie.Genre = Console.ReadLine();


                        movieLibrary.EditMovie(editebleMovieTitle, editMovie);

                        break;
                    case "6":
                        MovieMember registr = new MovieMember();
                        Console.Write("Enter name: ");
                        registr.Name = Console.ReadLine();

                        Console.Write("Enter lastname: ");
                        registr.LastName = Console.ReadLine();
                        registr.Id++;

                        Console.Write("Enter password: ");
                        registr.Password = Console.ReadLine();


                        string patern = "@";
                        Console.Write("Enter mail: ");
                        registr.Mail = Console.ReadLine();
                        bool isMatch = Regex.IsMatch(registr.Mail, patern);

                        registr.RegistrationData = DateTime.Now;


                        if (isMatch)
                        {
                            movieMember.Registration(registr);
                        }
                        else
                        {
                            Console.WriteLine("Incorect mail!!!");
                        }




                        break;
                    case "7":
                        movieMember.Print();
                        break;
                    case "8":
                        Console.Write("Enter id to remove member: ");
                        int removeMember = int.Parse(Console.ReadLine());

                        movieMember.RemoveMember(removeMember);
                        break;
                    case "9":
                        Console.Write("Enter name search member: ");
                        string memberName = Console.ReadLine();

                        var searched = movieMember.Search(memberName);
                        foreach (var item in searched)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "10":
                        MemberInfo();
                        break;
                    default:
                        Console.WriteLine("Wrong input enter correct!!!");
                        break;



                }
            }
        }





        public static void MemberInfo()
        {
            int quantity = 0;

            while (true)
            {
                try
                {
                    MovieMember member = new MovieMember();


                    Console.Write("Enter user name: ");
                    string logName = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();

                    quantity++;
                    Console.WriteLine(quantity);
                    if (member.Login(logName, password) && quantity != 3)
                    {
                        Console.WriteLine("loged");
                        Console.WriteLine("---------");
                        
                        
                        WatchMovie();

                    }
                    else if (quantity == 3)
                    {

                        
                        Console.WriteLine("Forget password recovery your information!!!");
                        Console.WriteLine("----------------------------");

                        Console.Write("Enter user name: ");
                        string recoveryUserName = Console.ReadLine();

                        Console.Write("Enter new password: ");
                        member.Password = Console.ReadLine();


                        member.RecoveryInformation(recoveryUserName, member);
                        quantity = 0;

                    }
                    else
                    {
                        Console.WriteLine("Wrong user try again!!!");

                    }


                }
                catch (Exception)
                {
                    Console.WriteLine("wrong user");
                    throw;

                }





            }
        }














    }
}
