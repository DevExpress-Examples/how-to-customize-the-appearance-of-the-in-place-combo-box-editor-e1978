﻿using System.Collections.Generic;
using System.Windows;

namespace TextEdit_EditNonEditableTemplate {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            List<Employee> data = new List<Employee>();
            data.Add(new Employee { Name = "Steven", CardColor = "Red" });
            data.Add(new Employee { Name = "Mary", CardColor = "Green" });
            data.Add(new Employee { Name = "John", CardColor = "Blue" });
            data.Add(new Employee { Name = "Claudia", CardColor = "Red" });
            gridControl1.ItemsSource = data;
        }
    }
    public class Employee {
        public string Name { get; set; }
        public string CardColor { get; set; }
    }
}