using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            float filmBackWidth, fLength , fov;
            filmBackWidth = float.Parse(Console.ReadLine());
            fLength = float.Parse(Console.ReadLine());
            fov = float.Parse(Console.ReadLine());
            string mode;
            do
            {
                if (filmBackWidth > 0)
                {
                    Console.WriteLine("floats fLength and fov");
                    if (mode ='fLength')
                    {
                        do
                        {
                            fLength();
                            if (fLength > 0)
                            {
                                fov = 2 * (Math.Atan(filmBackWidth /(2*fLength))
                                Console.Write("fLength = {0}, fov = {1}", fLength, fov);
                            }
                        } while (fLength <= 0);
                        {
                            Console.Write("Invalid fLegnth.Please input again")
                        }
                    }
                    if (mode ='fov')
                    {
                        do
                        {
                            fov();
                            if (fov > 0.1 && fov < 6.28) 
                            {
                                fLength = filmBackWidth / (2 * Math.Tan(fov / 2))
                                Console.Write("fLength = {0}, fov = {1}", fLength, fov);
                            }
                        } while (fov < 0.1 && fov > 6.28);
                        {
                            Console.Write("Invalid fLegnth.Please input again")
                        }
                    }
                }
            } while (filmBackWidth <= 0);
            {
                Console.Write("Invalid filmBackWidth. Please input again");
            }
        }
    }
}
