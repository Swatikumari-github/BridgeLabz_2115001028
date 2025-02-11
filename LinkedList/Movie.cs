//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinkedList
//{
   

//    class Movie
//    {
//        public string Title;
//        public string Director;
//        public int Year;
//        public double Rating;
//        public Movie Next;
//        public Movie Prev;

//        public Movie(string title, string director, int year, double rating)
//        {
//            Title = title;
//            Director = director;
//            Year = year;
//            Rating = rating;
//            Next = null;
//            Prev = null;
//        }
//    }

//    class MovieList
//    {
//        private Movie head;
//        private Movie tail;

//        public void AddMovieAtBeginning(string title, string director, int year, double rating)
//        {
//            Movie newMovie = new Movie(title, director, year, rating);
//            if (head == null)
//            {
//                head = tail = newMovie;
//            }
//            else
//            {
//                newMovie.Next = head;
//                head.Prev = newMovie;
//                head = newMovie;
//            }
//        }

//        public void AddMovieAtEnd(string title, string director, int year, double rating)
//        {
//            Movie newMovie = new Movie(title, director, year, rating);
//            if (tail == null)
//            {
//                head = tail = newMovie;
//            }
//            else
//            {
//                tail.Next = newMovie;
//                newMovie.Prev = tail;
//                tail = newMovie;
//            }
//        }

//        public void AddMovieAtPosition(string title, string director, int year, double rating, int position)
//        {
//            if (position < 1)
//            {
//                Console.WriteLine("Invalid position!");
//                return;
//            }
//            Movie newMovie = new Movie(title, director, year, rating);
//            if (position == 1)
//            {
//                AddMovieAtBeginning(title, director, year, rating);
//                return;
//            }
//            Movie temp = head;
//            for (int i = 1; temp != null && i < position - 1; i++)
//            {
//                temp = temp.Next;
//            }
//            if (temp == null || temp.Next == null)
//            {
//                AddMovieAtEnd(title, director, year, rating);
//                return;
//            }
//            newMovie.Next = temp.Next;
//            newMovie.Prev = temp;
//            temp.Next.Prev = newMovie;
//            temp.Next = newMovie;
//        }

//        public void RemoveMovieByTitle(string title)
//        {
//            if (head == null)
//            {
//                Console.WriteLine("No movies to remove.");
//                return;
//            }
//            Movie temp = head;
//            while (temp != null && temp.Title != title)
//            {
//                temp = temp.Next;
//            }
//            if (temp == null)
//            {
//                Console.WriteLine("Movie not found.");
//                return;
//            }
//            if (temp == head)
//            {
//                head = head.Next;
//                if (head != null) head.Prev = null;
//            }
//            else if (temp == tail)
//            {
//                tail = tail.Prev;
//                tail.Next = null;
//            }
//            else
//            {
//                temp.Prev.Next = temp.Next;
//                temp.Next.Prev = temp.Prev;
//            }
//        }

//        public Movie SearchMovieByDirector(string director)
//        {
//            Movie temp = head;
//            while (temp != null)
//            {
//                if (temp.Director == director)
//                    return temp;
//                temp = temp.Next;
//            }
//            return null;
//        }

//        public Movie SearchMovieByRating(double rating)
//        {
//            Movie temp = head;
//            while (temp != null)
//            {
//                if (temp.Rating == rating)
//                    return temp;
//                temp = temp.Next;
//            }
//            return null;
//        }

//        public void DisplayMoviesForward()
//        {
//            Movie temp = head;
//            while (temp != null)
//            {
//                Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
//                temp = temp.Next;
//            }
//        }

//        public void DisplayMoviesReverse()
//        {
//            Movie temp = tail;
//            while (temp != null)
//            {
//                Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
//                temp = temp.Prev;
//            }
//        }

//        public void UpdateMovieRating(string title, double newRating)
//        {
//            Movie temp = head;
//            while (temp != null)
//            {
//                if (temp.Title == title)
//                {
//                    temp.Rating = newRating;
//                    Console.WriteLine("Rating updated successfully.");
//                    return;
//                }
//                temp = temp.Next;
//            }
//            Console.WriteLine("Movie not found.");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            MovieList movieList = new MovieList();

//            movieList.AddMovieAtEnd("Gangs of Waseypur", "Anurag Kashyap", 2019, 8.8);
//            movieList.AddMovieAtEnd("3Iditos", "Rajkumar Hirani", 2010, 8.6);
//            movieList.AddMovieAtBeginning("M.S. Dhoni: The Untold Story (2016)", "Niraj Pandey", 2010, 7.5);

//            Console.WriteLine("Movies in forward order:");
//            movieList.DisplayMoviesForward();

//            Console.WriteLine("\nUpdating Rating for '3Iditos':");
//            movieList.UpdateMovieRating("3iditos", 9.1);
//            movieList.DisplayMoviesForward();

//            Console.WriteLine("\nRemoving 'Inception':");
//            movieList.RemoveMovieByTitle("Inception");
//            movieList.DisplayMoviesForward();

//            Console.WriteLine("\nMovies in reverse order:");
//            movieList.DisplayMoviesReverse();
//        }
//    }
//}
