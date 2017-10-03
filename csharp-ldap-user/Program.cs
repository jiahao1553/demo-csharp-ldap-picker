using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.ActiveDirectoryObjectPicker;

namespace csharp_ldap_user
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryObjectPickerDialog picker = new DirectoryObjectPickerDialog()
            {
                AllowedObjectTypes = ObjectTypes.All,
                DefaultObjectTypes = ObjectTypes.Users,
                AllowedLocations = Locations.All,
                DefaultLocations = Locations.JoinedDomain,
                MultiSelect = true,
                ShowAdvancedView = true
            };


            if (picker.ShowDialog() == DialogResult.OK)
            {
                foreach (var sel in picker.SelectedObjects)
                {
                    Console.WriteLine(sel.Name);
                }
            }
        }
    }
}
