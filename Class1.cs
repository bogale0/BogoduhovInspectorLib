namespace InspectorLib
{
    public class FunctionInsp
    {
        string name;
        string inspector;
        List<string> workers;
        //конструктор класса
        public FunctionInsp(string name, string insp, List<string> wkrs)
        {
            this.name = name;
            inspector = insp;
            workers = wkrs;
        }
        //главный инспектор
        public string GetInspector()
        {
            return inspector;
        }
        //название инспекции
        public string GetСarInspection()
        {
            return name;
        }
        //возвращает true, если главный инспектор был изменён и false в случае, если fullname не содержится в списке работников
        public bool SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                inspector = fullname;
                return true;
            }
            return false;
        }
        //в госномере символ в верхнем регистре, после него идёт число, нижнее подчёркивание и код региона (по умолчанию 75)
        public string GenerateNumber(int number, char symbol, int code = 75)
        {
            return $"{symbol.ToString().ToUpper()}{number}_{code}";
        }
        //список работников
        public List<string> GetWorker()
        {
            return workers;
        }
        //добавляем рабочего в список
        public void AddWorker(string worker)
        {
            workers.Add(worker);
        }
    }
}
