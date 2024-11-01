// using System;
//задание 1
// namespace matrica
// {
//     public class Matrix
//     {
//         private int[,] data;
//         public int Rows { get; private set; }
//         public int Columns { get; private set; }
//         public Matrix(int rows, int columns)
//         {
//             Rows = rows;
//             Columns = columns;
//             data = new int[rows, columns];
//         }
//         public Matrix(int[,] array)
//         {
//             Rows = array.GetLength(0);
//             Columns = array.GetLength(1);
//             data = array;
//         }
//         public void Input()
//         {
//             Console.WriteLine("Введите элементы:");
//             for (int i = 0; i < Rows; i++)
//             {
//                 for (int j = 0; j < Columns; j++)
//                 {
//                     Console.Write($"Элемент [{i},{j}]: ");
//                     data[i, j] = int.Parse(Console.ReadLine());
//                 }
//             }
//         }
//         public void Output()
//         {
//             Console.WriteLine("Матрица:");
//             for (int i = 0; i < Rows; i++)
//             {
//                 for (int j = 0; j < Columns; j++)
//                 {
//                     Console.Write(data[i, j] + "\t");
//                 }
//                 Console.WriteLine();
//             }
//         }
//         public int Max()
//         {
//             int max = data[0, 0];
//             foreach (int value in data)
//             {
//                 if (value > max) 
//                     max = value;
//             }
//             return max;
//         }
//         public int Min()
//         {
//             int min = data[0, 0];
//             foreach (int value in data)
//             {
//                 if (value < min) 
//                     min = value;
//             }
//             return min;
//         }
//         public static Matrix operator +(Matrix a, Matrix b)
//         {
//             Matrix result = new Matrix(a.Rows, a.Columns);
//             for (int i = 0; i < a.Rows; i++)
//             {
//                 for (int j = 0; j < a.Columns; j++)
//                 {
//                     result.data[i, j] = a.data[i, j] + b.data[i, j];
//                 }
//             }
//             return result;
//         }
//         public static Matrix operator -(Matrix a, Matrix b)
//         {
//             Matrix result = new Matrix(a.Rows, a.Columns);
//             for (int i = 0; i < a.Rows; i++)
//             {
//                 for (int j = 0; j < a.Columns; j++)
//                 {
//                     result.data[i, j] = a.data[i, j] - b.data[i, j];
//                 }
//             }
//             return result;
//         }
//         public static Matrix operator *(Matrix a, Matrix b)
//         {
//             Matrix result = new Matrix(a.Rows, b.Columns);
//             for (int i = 0; i < result.Rows; i++)
//             {
//                 for (int j = 0; j < result.Columns; j++)
//                 {
//                     result.data[i, j] = 0;
//                     for (int k = 0; k < a.Columns; k++)
//                     {
//                         result.data[i, j] += a.data[i, k] * b.data[k, j];
//                     }
//                 }
//             }
//             return result;
//         }
//         public static Matrix operator *(Matrix a, int scalar)
//         {
//             Matrix result = new Matrix(a.Rows, a.Columns);
//             for (int i = 0; i < a.Rows; i++)
//             {
//                 for (int j = 0; j < a.Columns; j++)
//                 {
//                     result.data[i, j] = a.data[i, j] * scalar;
//                 }
//             }
//             return result;
//         }
//         public static bool operator ==(Matrix a, Matrix b)
//         {
//             if (a.Rows != b.Rows || a.Columns != b.Columns)
//                 return false;
//
//             for (int i = 0; i < a.Rows; i++)
//             {
//                 for (int j = 0; j < a.Columns; j++)
//                 {
//                     if (a.data[i, j] != b.data[i, j])
//                         return false;
//                 }
//             }
//             return true;
//         }
//         public static bool operator !=(Matrix a, Matrix b)
//         {
//             return !(a == b);
//         }
//         public override bool Equals(object obj)
//         {
//             if (obj is Matrix matrix)
//             {
//                 return this == matrix;
//             }
//             return false;
//         }
//         public override int GetHashCode()
//         {
//             return data.GetHashCode();
//         }
//         public int this[int row, int col]
//         {
//             get { return data[row, col]; }
//             set { data[row, col] = value; }
//         }
//     }
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Matrix matrix1 = new Matrix(2, 2);
//             matrix1.Input();
//             matrix1.Output();
//             Matrix matrix2 = new Matrix(2, 2);
//             matrix2.Input();
//             matrix2.Output();
//             Matrix sum = matrix1 + matrix2;
//             Console.WriteLine("Сумма:");
//             sum.Output();
//             Matrix difference = matrix1 - matrix2;
//             Console.WriteLine("Разность:");
//             difference.Output();
//             Matrix product = matrix1 * matrix2;
//             Console.WriteLine("Произведение:");
//             product.Output();
//             Console.WriteLine("Максимум: " + matrix1.Max());
//             Console.WriteLine("Минимум: " + matrix2.Min());
//             Matrix scaledMatrix = matrix1 * 3;
//             Console.WriteLine("Умножение первой матрицы на 3:");
//             scaledMatrix.Output();
//             Console.WriteLine("Матрицы равны?: " + (matrix1 == matrix2));
//
//           
//         }
//     }
// }
//



//задание 2
// public class Book
// {
//     public string Title { get; set; }
//     public string Author { get; set; }
//
//     public Book(string title, string author)
//     {
//         Title = title;
//         Author = author;
//     }
//
//     public override string ToString()
//     {
//         return $"{Title} - {Author}";
//     }
//
//     public static bool operator ==(Book a, Book b)
//     {
//         if (ReferenceEquals(a, b)) return true;
//         if (a is null || b is null) return false;
//         return a.Title == b.Title && a.Author == b.Author;
//     }
//
//     public static bool operator !=(Book a, Book b) => !(a == b);
//
//     public override bool Equals(object obj)
//     {
//         if (obj is Book book)
//             return this == book;
//         return false;
//     }
//
//     public override int GetHashCode()
//     {
//         return (Title, Author).GetHashCode();
//     }
// }
//
// public class Reading
// {
//     private List<Book> books = new List<Book>();
//
//     public Book this[int index]
//     {
//         get => books[index];
//         set => books[index] = value;
//     }
//
//     public void Add(Book book)
//     {
//         if (!books.Contains(book))
//         {
//             books.Add(book);
//             Console.WriteLine($"Книга '{book.Title}' добавлена");
//         }
//     }
//
//     public void Remove(Book book)
//     {
//         if (books.Remove(book))
//         {
//             Console.WriteLine($"Книга '{book.Title}' удалена");
//         }
//     }
//
//     public bool Poisk(Book book)
//     {
//         return books.Contains(book);
//     }
//
//     public void Print()
//     {
//         if (books.Count == 0)
//         {
//             Console.WriteLine("Список пустой");
//         }
//         else
//         {
//             Console.WriteLine("Список для чтения:");
//             foreach (var book in books)
//             {
//                 Console.WriteLine(book);
//             }
//         }
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Reading read = new Reading();
//         Book book1 = new Book("Властелин колец", "Джон Р. Р. Толкин");
//         Book book2 = new Book("Гордость и предубеждение", "Джейн Остин");
//         Book book3 = new Book("Тёмные начала", "Филип Пулман");
//
//         read.Add(book1);
//         read.Add(book2);
//         read.Add(book3);
//         read.Add(book2);
//
//         read.Print();
//
//         read.Remove(book3);
//         bool found = read.Poisk(book3);
//         Console.WriteLine(found ? "Книга есть в списке." : "Книги нет в списке.");
//
//         Console.WriteLine($"Первая книга в списке: {read[0]}");
//         read[0] = new Book("Алиса в стране чудес", "Льюис Кэрролл");
//         read.Print();
//     }
// }
//
//
