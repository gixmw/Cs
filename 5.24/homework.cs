using System.Xml.Linq;
using System.Collections.Concurrent;

class AddressBook
{

    static Dictionary<string, string> a = new Dictionary<string, string>();

    static void Main()
    {     
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. 주소록 조회");
            Console.WriteLine("2. 주소록 추가");
            Console.WriteLine("3. 주소록 탐색 및 전화번호 수정");
            Console.WriteLine("4. 주소록 삭제");
            Console.WriteLine("5. 나가기");
            int z = Convert.ToInt32(Console.ReadLine());

            switch (z)
            {
                case 1:
                    show();
                    break;

                case 2:
                    add();
                    break;

                case 3:
                    correction();
                    break;

                case 4:
                    remove();
                    break;

                case 5:
                    exit = true;
                    break;
            }
        }
    }

    static void show()
    {
        Console.WriteLine("주소록 : ");

        if (a != null)
        {
            if(a.Count > 0)
            {
                foreach (var item in a)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            
            else
            {
                Console.WriteLine("비어있습니다.");
            }
        } 
        
        else 
        { 
            Console.WriteLine("비어있습니다."); 
        }
    }

    static void add()
    {
        Console.WriteLine("추가할 이름을 입력하세요: ");
        string name = Console.ReadLine();

        Console.WriteLine("추가할 전화번호를 입력하세.: ");
        string call = Console.ReadLine();

        a[name] = call;
        Console.WriteLine("주소록에 추가되었습니다.");
    }

    static void correction()
    {
        Console.WriteLine("탐색할 이름을 입력해주세요.");
        string name = Console.ReadLine();

        if (a.ContainsKey(name))
        {
            string call = Console.ReadLine();
            a[name] = call;
        }

        else 
        {
            Console.WriteLine("탐색할 수 없습니다.");
        }
    }

    static void remove()
    {
        Console.WriteLine("삭제할 이름을 입력하세요");
        string name = Console.ReadLine();

        if (a.ContainsKey(name))
        {
            a.Remove(name);
            Console.WriteLine("주소록에서 해당 이름과 전화번호가 삭제되었습니다.");
        }

        else 
        { 
            Console.WriteLine("해당하는 이름은 존재 하지 않습니다."); 
        }
    }
}

