using FamilyResearch.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyResearch.UI
{
    class ApplicationEntryPoint : IApplicationEntryPoint
    {
        private readonly IPersonController _PersonController;

        public ApplicationEntryPoint(IPersonController personController)
        {
            _PersonController = personController;
        }

        public void Run()
        {
            using (var form = new Form1(_PersonController))
                form.ShowDialog();
        }

        public void Dispose()
        {

        }
    }
}
