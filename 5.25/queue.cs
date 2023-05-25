sing System;
using System.Collections;
using System.Collections.Concurrent;

class program
{ 
    static string[] qu = new string[5];
    static int rear=0, flont=0;
    static string z;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1: 값 추가, 2: 값 삭제, 3: 확인, 그 외: 삭제");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            { 
                case 1:
                    add();
                    break;
                case 2:
                    remove();
                    break;
                case 3:
                    check();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    static void add()
    {
        ++rear;
        if(flont == (rear+1) % qu.Length) 
        {
            Console.WriteLine("추가할 수 없습니다.");
        }
        else
        {
            Console.WriteLine("값을 입력해주세요");
            z = Console.ReadLine();
            qu[rear] = z;
            Console.WriteLine("값 : " + qu[rear]);
        }
    }

    static void remove() 
    {
        ++flont;
        if (flont == rear)
        {
            Console.WriteLine("삭제할 수 없습니다.");
        }
        else
        { 
            Console.WriteLine("삭제할 값: " + qu[flont]);
            qu[flont] = null;

        }
    }
    static void check()
    {
        Console.WriteLine("저장된 값 : ");
        for (int i = 0; i < qu.Length; i++)
        {
            Console.WriteLine(qu[i]);
        }
    }
}
