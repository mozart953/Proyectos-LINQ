using System.Collections.Generic;
/* Cambio no fusionado mediante combinación del proyecto 'TCPData'
Antes:
using System.Text;
using System.Collections.Generic;
Después:
using System.Collections.Generic;
using System.Text;
*/


namespace TCPData
{
    public static class Data
    {
#pragma warning disable CS0436 // El tipo 'Employee' de 'C:\Users\Wilson Pop\Documents\Visual Studio 2019\Projects\ThePretendCompanyApplication\TCPData\Employee.cs' está en conflicto con el tipo importado 'Employee' de 'TCPData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Wilson Pop\Documents\Visual Studio 2019\Projects\ThePretendCompanyApplication\TCPData\Employee.cs'.
        public static List<Employee> GetEmployees()
#pragma warning restore CS0436 // El tipo 'Employee' de 'C:\Users\Wilson Pop\Documents\Visual Studio 2019\Projects\ThePretendCompanyApplication\TCPData\Employee.cs' está en conflicto con el tipo importado 'Employee' de 'TCPData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Wilson Pop\Documents\Visual Studio 2019\Projects\ThePretendCompanyApplication\TCPData\Employee.cs'.
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 6000.3m,
                IsManager = true,
                DepartmentId = 1
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Jameson",
                AnnualSalary = 8000.1m,
                IsManager = true,
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 4000.1m,
                IsManager = false,
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Stevens",
                AnnualSalary = 3000.1m,
                IsManager = false,
                DepartmentId = 2
            };
            employees.Add(employee);

            return employees;
        }

#pragma warning disable CS0436 // El tipo 'Departament' de 'C:\Users\Wilson Pop\Documents\Visual Studio 2019\Projects\ThePretendCompanyApplication\TCPData\Departament.cs' está en conflicto con el tipo importado 'Departament' de 'TCPData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Wilson Pop\Documents\Visual Studio 2019\Projects\ThePretendCompanyApplication\TCPData\Departament.cs'.
        public static List<Departament> GetDepartaments()
#pragma warning restore CS0436 // El tipo 'Departament' de 'C:\Users\Wilson Pop\Documents\Visual Studio 2019\Projects\ThePretendCompanyApplication\TCPData\Departament.cs' está en conflicto con el tipo importado 'Departament' de 'TCPData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Wilson Pop\Documents\Visual Studio 2019\Projects\ThePretendCompanyApplication\TCPData\Departament.cs'.
        {

            List<Departament> departaments = new List<Departament>();

            Departament departament = new Departament
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources"

            };
            departaments.Add(departament);

            departament = new Departament
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance"

            };
            departaments.Add(departament);

            departament = new Departament
            {
                Id = 3,
                ShortName = "TE",
                LongName = "Technology"

            };
            departaments.Add(departament);

            return departaments;
        }
    }
}
