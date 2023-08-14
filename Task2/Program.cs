namespace Task2
{
    public class PhotoBook
    {
        public PhotoBook(int numPages) { 
            _numPages = numPages;
        }
        private int _numPages;


        public int GetNumberPages() { 
        return _numPages;
        }

    }

    public class BigPhotoBook
    {
        public BigPhotoBook(int numPages)
        {
            _numPages = numPages;
        }

        private int _numPages { get; set; }

        public int GetNumberPages()
        {
            return _numPages;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBook photoBook =  new PhotoBook(16);
            Console.WriteLine(photoBook.GetNumberPages());

            PhotoBook photoBook2 = new PhotoBook(24);
            Console.WriteLine(photoBook2.GetNumberPages());

            BigPhotoBook largePhotoBook = new BigPhotoBook(64);
            Console.WriteLine(largePhotoBook.GetNumberPages());
        }
    }
}