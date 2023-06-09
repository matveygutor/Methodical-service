﻿using MaterialDesignThemes.Wpf;
using MethodicalService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MethodicalService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawMenu();
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);
            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }

        private void DrawMenu()
        {
            List<SubItem> methodicalWork = new()
            {
                new SubItem("Внеуч. работа", PackIconKind.Work),
                new SubItem("Проф. развитие", PackIconKind.ProfessionalHexagon),
                new SubItem("Пед. опыт", PackIconKind.ExpandAll),
                new SubItem("Мат. база", PackIconKind.Material),
                new SubItem("Мероприятия", PackIconKind.Event),
                new SubItem("Отк. занятия", PackIconKind.School),
                new SubItem("Посещ. занятий", PackIconKind.Schedule)
            };
            ItemMenu firstItem = new("Метод. работа", methodicalWork, PackIconKind.AccountStudent);

            List<SubItem> teachingLoad = new()
            {
                new SubItem("Нагрузка", PackIconKind.Register)
            };
            ItemMenu secondItem = new("Пед. нагрузка", teachingLoad, PackIconKind.Teacher);

            List<SubItem> updDevelopment = new()
            {
                new SubItem("Поступление УПД" , PackIconKind.JournalMultiple, new Forms.ExtracurricularWorkForm()),
                new SubItem("Распределение УПД" , PackIconKind.JournalOutline, new Forms.Distribution_log()),
                new SubItem("Планы разр. УПД", PackIconKind.Work)
            };
            ItemMenu thirdItem = new("УПД", updDevelopment, PackIconKind.DocumentSign);

            Menu.Children.Add(new ViewModel.MenuItem(thirdItem, this));
            Menu.Children.Add(new ViewModel.MenuItem(secondItem, this));
            Menu.Children.Add(new ViewModel.MenuItem(firstItem, this));
        }
    }
}
