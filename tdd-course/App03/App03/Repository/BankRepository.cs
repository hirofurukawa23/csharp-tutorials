using App03.ValueObjects;
using System.IO;

namespace App03.Repository
{
    public class BankRepository : IRepository
    {
        private readonly string _path;

        public BankRepository(string path)
        {
            this._path = path;
        }

        public Money Read()
        {
            var balance = ReadFile();
            return new Money(balance);
        }

        private int ReadFile()
        {
            if (!CanReadFile()) { return 0; }

            var txt = File.ReadAllText(_path);
            if (int.TryParse(txt, out var converted))
            {
                return converted;
            }
            return 0;
        }

        private bool CanReadFile()
        {
            return File.Exists(_path);
        }


        public void Write(Money money)
        {
            if (!CanWriteFile()) { return; }
            var txt = (money.Value).ToString();
            WriteToFile(txt);
        }

        private bool CanWriteFile()
        {
            var directory = GetParent();
            if (!IsExistDirectory(directory))
            {
                CreateDirectory(directory);
            }
            return true;
        }

        private void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        private bool IsExistDirectory(string path)
        {
            return Directory.Exists(path);
        }

        private string GetParent()
        {
            return Directory.GetParent(_path).FullName;
        }

        private void WriteToFile(string txt)
        {
            File.WriteAllText(_path, txt);
        }
    }
}
