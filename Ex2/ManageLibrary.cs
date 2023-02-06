using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class ManageLibrary
    {
        public List<Document> Documents { get; set; }
        public ManageLibrary(List<Document> Documents)
        {
            this.Documents = Documents;
        }
        public bool AddDocument(Document Doc)
        {
            if (Documents.Where(x => x.Id == Doc.Id).Any())
            {
                return false;
            }
            this.Documents.Add(Doc);
            return true;
        }

        public bool RemoveOfficer(int ID) {
            var result = this.Documents.Find(x => x.Id == ID);    
            if (result != null)
            {
                this.Documents.Remove(result);
                return true;
            }
            return false;
        }

        public bool SearchDocumentByType(String Type)
        {
            if (String.IsNullOrEmpty(Type)) return false;
            if (Type.Equals("book"))
            {
                var result = Documents.FindAll(x => x.GetType() == typeof(Book));
                if (result.Count != 0)
                {
                    foreach (var item in result)
                    {
                        item.Print();
                    }
                    return true;
                }
            }
            if (Type.Equals("news"))
            {
                var result = Documents.FindAll(x => x.GetType() == typeof(News));
                if (result.Count != 0)
                {
                    foreach (var item in result)
                    {
                        item.Print();
                    }
                    return true;
                }
            }
            if (Type.Equals("journal"))
            {
                var result = Documents.FindAll(x => x.GetType() == typeof(Journal));
                if (result.Count != 0)
                {
                    foreach (var item in result)
                    {
                        item.Print();
                    }
                    return true;
                }
            }
            return false;
        }
        public void ShowDetails()
        {
            foreach (Document item in Documents)
            {
                item.Print();
            }
        }
    }
}
