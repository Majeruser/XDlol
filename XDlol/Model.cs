using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDlol
{
    public class Model
    {
        public List<Cars> car = new();
        private void Import(string filename)
        {
            car = File.ReadAllLines(filename).Skip(1).Select(x => new Cars(x)).ToList();
        }
        public Model()
        {
            Import("cars.txt");
        }
        // feladat1
        public List<string> Afteryer(int year) { 
            return car.Where(x => x.Buildyear >year).Select(x => x.Type).ToList();
        }
        // feladat2
        public List<string> StHp(int hp)
        {
            return car.Where(x => x.Hp > hp).Select(x => x.Type).ToList();
        }
        // feladat3
        public List<string> Expensive(int price) { 
            return car.Where( x=> x.Price < price).Select(x => x.Type).ToList();
        }
        // feladat4
        public int CountBrand(string brand)
        {
            return car.Where(x => x.Brand == brand).Count();
        }
        // feladat5
        public bool IsBrand(string brand)
        {
            return car.Any(x => x.Brand == brand);
        }
        // feladat6
        public bool loero(int loero)
        {
            return car.Any(x => x.Hp > loero);
        }
        // feladat7
        public int Maxprice()
        {
            return car.Max(x => x.Price);
        }
        // feladat8
        public double AvgBrand(string brand)
        {
            return car.Where(x => x.Brand == brand).Average(x => x.Hp);
        }
        // feladat9
        public double AvgPrice()
        {
            return car.Average(x => x.Price);
        }
        // feladat11
        public List<string> AscPrice()
        {
            return car.OrderBy(x => x.Price).Select(x => x.Type).ToList();
        }
        // feladat12
        public List<string> DescHp()
        {
            return car.OrderByDescending(x => x.Hp).Select(x => x.Type).ToList();
        }
        // feladat13
        public List<string> Betwen(int year1, int year2) { 
         return car.Where( x => x.Buildyear > year1 && x.Buildyear <year2).Select(x => x.Type).ToList();
        }
        // feladat14
        public List<string> MinHpAndCheaper(int minHp, int maxprice) { 
            return car.Where(x => x.Hp >= minHp && x.Price < maxprice).Select(x => x.Type).ToList();
        }
        // feladat15
        public string Mostnew() {
         return car.OrderByDescending(x => x.Buildyear).Select(x => x.Type).First();
        }
        // feladat16
        public string Mostold()
        {
            return car.OrderBy(x => x.Buildyear).Select(x => x.Type).First();
        }
        // feladat17
        public List<string> MEPsev(int db)
        {
            return car.OrderByDescending(x => x.Price).Select(x => x.Type).Take(db).ToList();
        }
        // feladat19
        public List<string>Brandmaxing(string brand)
        {
            return car.Where(x => x.Brand == brand).OrderByDescending(x => x.Hp).Select(x => x.Type).ToList();
        }
        // feladat20
        public int BrandmaxC(int year)
        {
            return car.Where(x => x.Buildyear >= year).Count();

        }
        // feladat21
        public double Avgmaxing(int minhp)
        {
            return car.Where(x => x.Hp >= minhp).Average(x => x.Price);
        }
        // feladat22
        public string PriceMaxing(int minprjsz)
        {
            return car.Where(x => x.Price > minprjsz).OrderBy(x => x.Price).Select(x => x.Type).First();
        }
        // feladat23
        public string StrongestYoungermaxing(int year)
        {
            return car.Where(x => x.Buildyear > year).OrderByDescending(x => x.Hp).Select(x => x.Type).First();
        }
        // feladat24
        public List<string> BelowAvgMAxing()
        {
            return car.Where(x => x.Price < car.Average(x => x.Price)).OrderByDescending(x => x.Price).Select(x => x.Type).ToList();
        }
        // feladat25
        public List<string> markaMaxing()
        {
            return car.Select(x => x.Brand).Distinct().ToList();
        }
       // feladat27
       public  Dictionary<string, int> BrandOfCount()
        {
            return car.GroupBy(x => x.Brand).ToDictionary(x => x.Key, y => y.Count());
        }
       // feladat2
       // feladat2
       // feladat2
       // feladat2
       // feladat2
    }
}
