using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json; // Added this

namespace JSONpractice;

public partial class Form1 : Form
{
    private string jsonPath;

    public Form1()
    {
        InitializeComponent();
        // Initialize jsonPath and bind grid on form creation
        InitializeJsonPath();
        BindGrid();
    }

    private void InitializeJsonPath()
    {
        jsonPath = Path.Combine(Application.StartupPath, "Employees.json");
    }

    private void saveEmployeestofile(List<EmployeeModel> Employee)
    {
        try
        {
            // Ensure jsonPath is initialized
            if (string.IsNullOrEmpty(jsonPath))
            {
                InitializeJsonPath();
            }

            string json = JsonConvert.SerializeObject(
                Employee, Newtonsoft.Json.Formatting.Indented);

            // Create directory if it doesn't exist
            string directory = Path.GetDirectoryName(jsonPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(jsonPath, json);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void BindGrid()
    {
        if (string.IsNullOrEmpty(jsonPath))
        {
            InitializeJsonPath();
        }

        var emp = employee();
        dataGridView1.DataSource = emp;
    }

    private List<EmployeeModel> employee()
    {
        if (!File.Exists(jsonPath)) return new List<EmployeeModel>();

        string json = File.ReadAllText(jsonPath);
        if (string.IsNullOrEmpty(json)) return new List<EmployeeModel>();

        try
        {
            return JsonConvert.DeserializeObject<List<EmployeeModel>>(json) ?? new List<EmployeeModel>();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new List<EmployeeModel>();
        }
    }

    public void btnClear_Click(object sender, EventArgs e)
    {
        txtId.Text = "";
        txtName.Text = "";
        txtDesignation.Text = "";
        txtSalary.Text = "";
    }

    public void btnAdd_Click(object sender, EventArgs e)
    {
        var newemp = new EmployeeModel
        {
            ID = Convert.ToInt32(txtId.Text),
            Name = txtName.Text,
            Designation = txtDesignation.Text,
            Salary = Convert.ToInt32(txtSalary.Text)
        };

        var emp = employee();
        emp.Add(newemp);
        saveEmployeestofile(emp);
        BindGrid();
        btnClear_Click(sender, e);

        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    public void btnDelete_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(txtId.Text);
        var emp = employee();
        var deleteEmp = emp.FirstOrDefault(em => em.ID == id);
        if (deleteEmp != null)
        {
            emp.Remove(deleteEmp);
            saveEmployeestofile(emp);
            BindGrid();
        }
    }
    public void btnUpdate_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(txtId.Text);
        var emp = employee();
        var updateemp = emp.FirstOrDefault(em => em.ID == id);
        if (updateemp != null)
        {
            updateemp.Name = txtName.Text;
            updateemp.Designation = txtDesignation.Text;
            updateemp.Salary = Convert.ToInt32(txtSalary.Text);
            saveEmployeestofile(emp);
            BindGrid();
        }
    }
}
