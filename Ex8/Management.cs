using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    public class Management
    {
        private List<Card> cards;

        public Management(List<Card> cards)
        {
            this.cards = cards;
        }
        public bool AddCard (Card card) 
        { 
            if (cards.Where(x => x.Id == card.Id).Any()) 
            { 
                return false;
            }
            cards.Add(card);
            return true;
        }

        public bool RemoveCard (string Id) 
        {

            if (String.IsNullOrEmpty(Id)) return false;

            var card = this.cards.Where(card => card.Id == Id).FirstOrDefault();
            if (card != null)
            {
                cards.Remove(card);
                return true;
            }
            return false;
        }

        public void ShowDetails()
        {
            foreach ( Card item in cards)
            {
                item.Print();
            }
        }
    }
}
