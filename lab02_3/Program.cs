using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string secret_pro_key = "K3YPRO100";
            string secret_exp_key = "K3YEXppRO100";
            Console.WriteLine("Введите значение ключа для версии PRO:");
            string user_pro = Console.ReadLine();
            Console.WriteLine("Введите значение ключа для версии EXP:");
            string user_exp = Console.ReadLine();

            if (user_pro == secret_pro_key && user_exp != secret_exp_key)
            {
                Console.WriteLine("Вам открыт доступ к версии PRO:");
                ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                proDocumentWorker.OpenDocument();
                proDocumentWorker.EditDocument();
                proDocumentWorker.SaveDocument();
            } else if (user_exp == secret_exp_key)
            {
                Console.WriteLine("Вам открыт доступ к версии EXP:");
                ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                expertDocumentWorker.OpenDocument();
                expertDocumentWorker.EditDocument();
                expertDocumentWorker.SaveDocument();
            } else
            {
                Console.WriteLine("Бесплатная версия активна. Для активации версий PRO и EXPERT требуется специальный ключ.");
                DocumentWorker freeDocumentWorker = new DocumentWorker();
                freeDocumentWorker.OpenDocument();
                freeDocumentWorker.EditDocument();
                freeDocumentWorker.SaveDocument();
            }
        }
    }
}
