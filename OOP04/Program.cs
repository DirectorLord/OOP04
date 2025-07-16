using System.ComponentModel.DataAnnotations;

namespace OOP04
{
    public class Program
    {
        #region Part01
        #region Question01
        //a) To provide a way to implement multiple inheritance
        #endregion

        #region Question02
        //b) protected
        #endregion

        #region Question03
        //c) Only if they are static
        #endregion

        #region Question04
        //b) Yes, interfaces can inherit from multiple interfaces
        #endregion

        #region Question05
        //c) extends
        #endregion

        #region Question06
        //c) Only if the interface is sealed
        #endregion

        #region Question07
        //b) No, all members are implicitly public
        #endregion

        #region Question08
        //b) To provide a clear separation between interface and class members
        #endregion

        #region Question09
        //c) Yes, but only if the interface is sealed
        #endregion

        #region Question10
        //b) By using the "extends" keyword
        #endregion
        #endregion

        #region Part02

        #region Question01
        //Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle,
        ///that inherit from IShape. Implement these interfaces in classes Circle and Rectangle
        ///Test your implementation by creating instances of both classes and displaying their shape information.
        public interface Ishape
        {
            double area { get; }
            void DisplayShapeInfo();
        }
        //interface circle
        public interface ICircle : Ishape { }
        //interface rectangle
        public interface IRectangle : Ishape { }

        //the circle class
        public class Circle : ICircle
        {
            public double area { get; set; }
            public Circle(double area) { this.area = area; }
            public double Radius => Math.PI * area * area;
            public void DisplayShapeInfo()
            {
                Console.WriteLine($"the radius of the circle is: {Radius}, and the area of the rectangle is: {area}");
            }
        }
        //now just copy paste the circle interface and edit it and just add the width and edit the area
        public class Rectangle : IRectangle
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public double area => Length * Width;

            public Rectangle(double length, double width)
            {
                this.Length = length;
                this.Width = width;
            }

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"The width of the rectangle is: {Width}, the length of the rectangle is: {Length}, and the area is: {area}");
            }
        }
        #endregion

        #region Question02
        //lets see if i can copy paste the shape interface and edit it here
        public interface IAuthenticationService
        {
            bool AuthenticateUser(string username, string password);
            bool AuthorizeUser(string username, string role);
        }
        //implementation part
        public class BasicAuthenticationService : IAuthenticationService
        {
            public bool AuthenticateUser(string username, string password)
            {
                // cheap authentication methods
                if (username != null && password != null)
                {
                    return true;
                }
                return false;
            }

            public bool AuthorizeUser(string username, string role)
            {
                if (role != null && username != null)
                {
                    return true;
                }
                return false;
            }
        }
        #endregion

        #region Question03
        //copy paste this i think
        /*
            public void SendNotification(string recipient, string message)
            {
                Console.WriteLine($"Email sent to: {recipient}: {message}");
            }
         */
        public interface INotificationService
        {
            void SendNotification(string recipient, string message);
        }
        //email
        public class EmailNotificationService : INotificationService
        {
            public void SendNotification(string recipient, string message)
            {
                Console.WriteLine($"Email sent to: {recipient}: {message}");
            }
        }
        //sms
        public class SmsNotificationService : INotificationService {
            public void SendNotification(string recipient, string message)
            {
                Console.WriteLine($"SMS sent to: {recipient}: {message}");
            }
        }
        //push?
        public class PushNotificationService : INotificationService
        {
            public void SendNotification(string recipient, string message)
            {
                Console.WriteLine($"SMS sent to: {recipient}: {message}");
            }
        }
        #endregion
        #endregion
        public static void Main(string[] args)
        {
            #region part02
            #region Question01
            // Fix: Use the correct types instead of 'object' to call the method
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(5, 10);

            // Call the method directly on the correct types
            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
            #endregion

            #region Question02
            BasicAuthenticationService authService = new BasicAuthenticationService();
            bool isAuthenticated = authService.AuthenticateUser("user", "password");
            bool isAuthorized = authService.AuthorizeUser("user", "admin");
            Console.WriteLine($"Authentication: {isAuthenticated}, Authorized: {isAuthorized}");
            #endregion

            #region Question03
            EmailNotificationService emailService = new EmailNotificationService();
            SmsNotificationService smsNotificationService = new SmsNotificationService();
            PushNotificationService pushNotificationService = new PushNotificationService();

            emailService.SendNotification("user@gmail.com", "hello :)");
            smsNotificationService.SendNotification("015255155477", "hello :)");
            pushNotificationService.SendNotification("user2468", "hello :)");
            #endregion
            #endregion
        }
    }
}