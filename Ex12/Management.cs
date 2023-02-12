using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex12
{
    public class Management
    {
        public List<Transportation> Transportations { get; set; }
        public Management(List<Transportation> Transportations)
        {
            this.Transportations = Transportations;
        }
        public bool AddTransportation(Transportation trans)
        {
            if (Transportations.Where(x => x.Id == trans.Id).Any())
            {
                return false;
            }
            this.Transportations.Add(trans);
            return true;
        }

        public bool RemoveTransportation(int ID)
        {
            var result = this.Transportations.Find(x => x.Id == ID);
            if (result != null)
            {
                this.Transportations.Remove(result);
                return true;
            }
            return false;
        }

        public List<Transportation> SearchTransportationByProducer(String Producer)
        {
            if (String.IsNullOrEmpty(Producer)) return this.Transportations;
            var result = Transportations.FindAll(x => x.Producer.ToLower().Contains(Producer.ToLower()));
            if (!result.Any()) return new List<Transportation>();
            return result;
        }

        public List<Transportation> SearchTransportationByColor(String Color)
        {
            if (String.IsNullOrEmpty(Color)) return this.Transportations;
            var result = Transportations.FindAll(x => x.Color.ToLower().Contains(Color.ToLower()));
            if (!result.Any()) return new List<Transportation>();
            return result;
        }
        public void ShowDetails()
        {
            foreach (Transportation item in Transportations)
            {
                item.Print();
            }
        }
    }
}
