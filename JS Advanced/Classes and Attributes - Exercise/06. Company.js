class Company {
    constructor() {
        this.departments = {};
    }

    addEmployee(name, salary, position, department) {
        if (!this.isValidInput(name) ||
            !this.isValidInput(salary) ||
            !this.isValidInput(position) ||
            !this.isValidInput(department) ||
            salary < 0) {
            throw new Error('Invalid input!');
        }

        if (department in this.departments == false) {
            this.departments[department] = [];
        }

        this.departments[department].push({ name, salary, position });
        return `New employee is hired. Name: ${name}. Position: ${position}`;
    }

    bestDepartment() {
        let departmentWithHighestAvgSalary = '';
        let maxAvgSalary = 0;
        for (const [key, value] of Object.entries(this.departments)) {
            let totalSalaryDepartment = 0;
            value.forEach(employee => {totalSalaryDepartment += employee.salary;});
            let avgSalary = totalSalaryDepartment / value.length;
            if (avgSalary > maxAvgSalary) {
                maxAvgSalary = avgSalary;
                departmentWithHighestAvgSalary = key;
            }
          }

          let employees = this.departments[departmentWithHighestAvgSalary];
          employees.sort((a, b) => a.name.localeCompare(b.name));
          employees.sort((a, b) => b.salary - a.salary);
          let result = [`Best Department is: ${departmentWithHighestAvgSalary}\nAverage salary: ${maxAvgSalary.toFixed(2)}`];
          employees.forEach(employee => {result.push(`${employee.name} ${employee.salary} ${employee.position}`);});
          return result.join('\n');
    }

    isValidInput(input){
        return input != undefined && input != '' && input != null;
    }
}