using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarShop.Domain.Entities
{
    public abstract class Entitie
    {
        public List<string> _messagesValidation { get; set; }
        private List<string> messagesValidation { 
            get { return _messagesValidation ?? (_messagesValidation = new List<string>());  } 
        }

        protected void ClearMessagesValidation()
        {
            messagesValidation.Clear();
        }

        protected void AddMessagesValidation(string message)
        {
            messagesValidation.Add(message);
        }

        public abstract void Validate();
        protected bool IsValid{
            get { return messagesValidation.Any(); }
        }
    }
}
