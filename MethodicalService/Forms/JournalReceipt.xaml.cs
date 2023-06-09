﻿using Dapper;
using MaterialDesignThemes.Wpf;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MethodicalService.Forms
{
    /// <summary>
    /// Логика взаимодействия для ExtracurricularWork.xaml
    /// </summary>
    public partial class ExtracurricularWorkForm : UserControl
    {
        SqlDataAdapter? adapter = null;
        DataTable? receiptTable = null;

        public ExtracurricularWorkForm()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            SelectDataFromServer("sp_GetReceipt");
        }

        public void SelectDataFromServer(string sqlExpression)
        {
            //string sqlExpression = "sp_GetReceipt";
            SqlConnection connection = new(Properties.Resources.connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new(sqlExpression, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                receiptTable = new DataTable();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(receiptTable);
                receiptGrid.ItemsSource = receiptTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddReceipt addReceipt = new();
            addReceipt.buttonEdit.Visibility = Visibility.Hidden;
            DataRow row = receiptTable.NewRow();
            addReceipt.Build(row);
            if (addReceipt.ShowDialog() == true)
                receiptTable.Rows.Add(row);
            SelectDataFromServer("sp_GetReceipt");
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (receiptGrid.CurrentItem != null)
            {
                var row = (receiptGrid.CurrentItem as DataRowView).Row;
                AddReceipt add = new();
                add.buttonRegistr.Visibility = Visibility.Hidden;
                add.Build(row);
                add.ShowDialog();
                SelectDataFromServer("sp_GetReceipt");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string sqlExpression = "sp_DeleteReceipt";
            if (receiptGrid.SelectedItems != null)
            {
                if (MessageBox.Show("При удалении УПД будут удалены все распределенные экземпляры\nВы действительно хотите удалить эту запись?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    for (int i = 0; i < receiptGrid.SelectedItems.Count; i++)
                    {
                        if (receiptGrid.SelectedItems[i] is DataRowView)
                        {

                            var row = (receiptGrid.CurrentItem as DataRowView).Row;
                            string id = row["ID_Receipts"].ToString();
                            using SqlConnection connection = new(Properties.Resources.connectionString);
                            connection.Open();
                            SqlCommand command = new(sqlExpression, connection)
                            {
                                CommandType = CommandType.StoredProcedure
                            };

                            SqlParameter id_Parameter = new() { ParameterName = "@id", Value = id };
                            command.Parameters.Add(id_Parameter);
                            if (command.ExecuteNonQuery() != -1)
                            {
                                MessageBox.Show($"УПД с номером {id} успешно удалена", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                        }
                    }
                }
            }
            SelectDataFromServer("sp_GetReceipt");
        }

        private void Filters_Click(object sender, RoutedEventArgs e)
        {
            Filters filters = new();
            filters.Show();
        }

        private void TextSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            textSearch.Clear();
        }

        private void TextSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textSearch.Text == string.Empty)
            {
                textSearch.Text = "Поиск";
            }
            SelectDataFromServer("sp_GetReceipt");
        }

        private void TextSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textSearch.Text != string.Empty)
            {
                string sqlExpression = "sp_SearchReceipts";
                SqlConnection connection = new(Properties.Resources.connectionString);
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    SqlParameter value_Parameter = new() { ParameterName = "@value", Value = textSearch.Text };
                    command.Parameters.Add(value_Parameter);

                    receiptTable = new DataTable();
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(receiptTable);
                    receiptGrid.ItemsSource = receiptTable.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection?.Close();
                }
            }
            else
            {
                SelectDataFromServer("sp_GetReceipt");
            }
        }

        private void Distribution_Click(object sender, RoutedEventArgs e)
        {
            AddDistribution addDistribution = new();
            addDistribution.textNumberUPD.IsReadOnly = true;
            addDistribution.textName.IsReadOnly = true;
            try
            {
                if (receiptGrid.SelectedItem != null)
                {
                    DataRow row = (receiptGrid.CurrentItem as DataRowView).Row;
                    addDistribution.Show();
                    addDistribution.buttonEdit.Visibility = Visibility.Collapsed;
                    addDistribution.BuildForAdd(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void MenuAddEditDelete_Opened(object sender, RoutedEventArgs e)
        {

            if (receiptGrid.SelectedIndex == -1)
            {
                MenuItemDelete.Visibility = Visibility.Collapsed;
                MenuItemEdit.Visibility = Visibility.Collapsed;
                MenuItemRegistr.Visibility = Visibility.Collapsed;
                separator.Visibility = Visibility.Collapsed;
            }
            if (receiptGrid.SelectedIndex != -1)
            {
                MenuItemAdd.Visibility = Visibility.Collapsed;
                MenuItemRegistr.Visibility = Visibility.Visible;
                MenuItemDelete.Visibility = Visibility.Visible;
                MenuItemEdit.Visibility = Visibility.Visible;
                separator.Visibility = Visibility.Visible;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SelectDataFromServer("sp_GetIDAnOverdueUPD");
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            SelectDataFromServer("sp_GetReceipt");
        }

        private void receiptGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (receiptGrid.SelectedItem != null)
            {
                var row = (receiptGrid.CurrentItem as DataRowView).Row;
                string number = row["Number_the_UPD"].ToString();
                
                using IDbConnection db = new SqlConnection(Properties.Resources.connectionString);
                int count = (int)db.ExecuteScalar($"SELECT COUNT(ID_Receipts) FROM Distribution_log_with_Employee_and_Number_UPD WHERE ID_Receipts = {number}");
                MessageBox.Show($"Количество распределенных экземпляров УПД с номером {number}: {count}", "Результат обработки", MessageBoxButton.OK);

            }
        }
    }
}

