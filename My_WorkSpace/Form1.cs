using My_WorkSpace.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.EntityFramework.Plus;

namespace My_WorkSpace
{
    public partial class Form1 : Form
    {
        WorkSpaceEmplyes work = new WorkSpaceEmplyes();
        Employees employees = new Employees();
        object[] overtim = new object[] { 1, 2, 3, 4, 5 };
        public Form1()
        {
            InitializeComponent();

            cmbOderTime.Items.AddRange(overtim.ToArray());
            dgvEmloyess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            UpdateGrid();
            
        }
        public void UpdateGrid()
        {
            using (WorkSpace context = new WorkSpace())
            {
                dgvEmloyess.DataSource = context.Employees.ToList<Employees>();
                dgvEmployeeWork.DataSource= context.Employees.Join(context.SpaceEmplyes, x => x.Id, p => p.EmployeId, (x, p)
                    => new
                    {
                        Անուն = x.Name ,
                        Ազգանուն = x.LastName,
                        Սկիզբ = p.TimeIn,
                        Ավարտ = p.TimeOut,
                        Արտաժամ = p.Overtime
                    }).ToList();
            }
        }
        
        private void btnAddWork_Click(object sender, EventArgs e)
        {
            using (WorkSpace context = new WorkSpace())
            {
                
                work.EmployeId = employees.Id;
                work.TimeIn = datJoin.Value.ToShortTimeString();
                work.TimeOut = dateEnd.Value.ToShortTimeString();
                work.Overtime = cmbOderTime.SelectedItem?.ToString();

               
                    context.SpaceEmplyes.Add(work);
                context.SaveChanges();

                UpdateGrid();
            }
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            using (WorkSpace context = new WorkSpace())
            {
                context.Employees.RemoveRange(context.Employees.Where( x => x.Id == ((Employees)dgvEmloyess.CurrentRow.DataBoundItem).Id));
                context.SaveChanges();
            }
            UpdateGrid();
        }

       

        private void btnNewEmploye_Click(object sender, EventArgs e)
        {
            using (WorkSpace context = new WorkSpace())
            {

                employees.Name = txtName.Text;
                employees.LastName = txtLastName.Text;

                if (employees.Id < 0)
                    context.Entry(employees).State = EntityState.Modified;
                else
                    context.Employees.Add(employees);
                context.SaveChanges();

                UpdateGrid();
            }
        }

        private void dgvEmloyess_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employees.Id = ((Employees)dgvEmloyess.CurrentRow.DataBoundItem).Id;
            using (WorkSpace workSpace = new WorkSpace())
            {
                employees = workSpace.Employees.Where(x => x.Id == employees.Id).FirstOrDefault();
             
                txtEmployeAll.Text = employees.Name +" "+ employees.LastName;
            }
            btnAddWork.Text = "Խմբագրել";
        }

        private void dgvEmloyess_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvEmloyess.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chbStart.Checked)
            {
                datJoin.Value = DateTime.Now;
            }
            if (chbEnd.Checked)
            {
                dateEnd.Value = DateTime.Now;
            }
        }

        private void chbStart_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chbStart.Checked)
            {
                timer1.Start();
            }
            else
                timer1.Stop();
           
        }

        private void chbEnd_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbEnd.Checked)
            {
                timer1.Start();
            }
            else
                timer1.Stop();
            
        }

        private void dgvEmployeeWork_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvEmployeeWork.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
