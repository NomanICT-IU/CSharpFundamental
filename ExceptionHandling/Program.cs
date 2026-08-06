using System;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            //Console.WriteLine("Entrer a vaid user Id:");
            //int userId = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Entrer a vaid user Id:");
                int userId = Convert.ToInt32(Console.ReadLine());

                try
                {
                    //Console.WriteLine("Entrer a vaid user Id:");
                    //int userId = Convert.ToInt32(Console.ReadLine());



                    var user = service.GetUserId(userId);
                    var userResult = GetUserResult.Success(user);

                    Console.WriteLine(userResult.User.Name);
                }
                //catch (ArgumentException)
                //{
                //    var ErrorMsg = GetUserResult.Error("User Id should be between 1 and 1000.");
                //    Console.WriteLine(ErrorMsg.ErrorMessage);
                //}
                catch (InvalidUserIdException) when (userId <= 0)
                {
                    var ErrorMsg = GetUserResult.Error("User Id should be Positive.");
                    Console.WriteLine(ErrorMsg.ErrorMessage);
                }
                catch (InvalidUserIdException) when (userId >= 1000)
                {
                    var ErrorMsg = GetUserResult.Error("User Id should be less than or equal 1000.");
                    Console.WriteLine(ErrorMsg.ErrorMessage);
                }
                catch (InvalidOperationException)
                {
                    var ErrorMsg = GetUserResult.Error("User not found.");
                    Console.WriteLine(ErrorMsg.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                service?.Clear();
            }

        }
    }
}
