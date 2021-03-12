using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewTree
{
    public partial class MainMenu : Form
    {

        SqlConnection connection = new SqlConnection(); // Строка подключения
        TreeNode node_here = new TreeNode();            // ВЫбранная нода TreeView
        List<string> ItemsName = new List<string>();    // Коллекция имен предметов
        List<string> Types = new List<string>();        // Коллекция названий типов предметов
        List<string> Equipments = new List<string>();   // Коллекция названий видов снаряжения
        List<Item> Items = new List<Item>();            // Коллекция предметов
        Item updateItem = new Item();                   // Предмет, который нужно обновить
        int indexName;                                  // Позиция выбранного предмета            

        // Конструктор класса
        public MainMenu()
        {
            InitializeComponent();
        }

        // Запуск приложения
        #region AppLoad
        
            // Обработчик главного окна при его загрузке
            private void MainMenu_Load(object sender, EventArgs e)
            {
                DBConnection();
                comboBox_ItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBox_AttributeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            }

            // Подключение к БД
            public void DBConnection()
        {
            connection.ConnectionString = @"Data Source=BLADEZ;Initial Catalog=Inventory system;Integrated Security=True";
            connection.Open();
        }

        #endregion

        // Показать TreeView
        #region ShowTreeView

        // Получить виды снаряжения для вершин TreeView 
        public void GetEquipment()
            {
                SqlCommand command = new SqlCommand("SELECT * FROM EquipmentTypes", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        TreeNode node = new TreeNode(dataReader["Title Equipment type"].ToString().Trim());
                        treeView1.Nodes.Add(node);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Получить типы предметов для вершин TreeView 
            public void GetItemTypes()
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ItemTypes", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Types.Add(dataReader["Title Type"].ToString().Trim());
                        TreeNode node = new TreeNode(dataReader["Title Type"].ToString().Trim());
                        treeView1.Nodes[Convert.ToInt32(dataReader["ID Equipment"]) - 1].Nodes.Add(node);
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Получить предметы для вершин TreeView 
            public void GetItems()
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Items ORDER BY [ID Item] ASC", connection);
                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Item item = new Item();
                        item.ID_Item = Convert.ToInt32(dataReader["ID Item"]);
                        item.Item_Name = dataReader["Item Name"].ToString().Trim();
                        item.Item_Type = Convert.ToInt32(dataReader["Item Type"]);
                        item.Attribute_Indicator = Convert.ToInt32(dataReader["Attribute indicator"]);
                        item.Attribute_Name = dataReader["Attribute name"].ToString().Trim();
                        item.Description = dataReader["Description"].ToString().Trim();
                        item.Worth = Convert.ToInt32(dataReader["Worth"]);
                        Items.Add(item);

                        ItemsName.Add(dataReader["Item Name"].ToString().Trim());
                        TreeNode node_item = new TreeNode(dataReader["Item Name"].ToString().Trim());

                        string attribute = "+" + dataReader["Attribute indicator"].ToString().Trim() + " " + dataReader["Attribute name"].ToString().Trim();
                        node_item.Nodes.Add(attribute);

                        node_item.Nodes.Add(dataReader["Description"].ToString().Trim());
                        string worth = dataReader["Worth"].ToString().Trim() + " кобан";
                        node_item.Nodes.Add(worth);

                        if(Convert.ToInt32(dataReader["Item Type"]) <= 2)
                        {
                            treeView1.Nodes[0].Nodes[Convert.ToInt32(dataReader["Item Type"]) - 1].Nodes.Add(node_item);
                        }
                        else if (Convert.ToInt32(dataReader["Item Type"]) <= 6)
                        {
                            treeView1.Nodes[1].Nodes[Convert.ToInt32(dataReader["Item Type"]) - 3].Nodes.Add(node_item);
                        }
                        else
                        {
                            treeView1.Nodes[2].Nodes[Convert.ToInt32(dataReader["Item Type"]) - 7].Nodes.Add(node_item);
                        }
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Загрузить БД в TreeView
            public void DBtoTreeView()
            {
                treeView1.Nodes.Clear();
                GetEquipment();
                GetItemTypes();
                GetItems();
            }

            // Оброботчик событый для кнопки ЗАГРУЗИТЬ БАЗУ ДАННЫХ
            private void button_GetItems_Click(object sender, EventArgs e)
            {
                DBtoTreeView();
                button_GetItems.Enabled = false;
            }

        #endregion
    
        // Удаление предмета
        #region deleteItem

            // Обработчик событий при нажатии кнопки УДАЛИТЬ
            public void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
            {
                delete();
            }

            // Удаление выбранного предмета из БД
            public void delete()
            {
                string itemName = node_here.Text;
                using (SqlCommand command = new SqlCommand($"DELETE FROM Items WHERE[Item Name] = '{itemName}'", connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Item item = Items.Find(it => it.Item_Name == itemName);
                        if (item.Item_Type <= 2)
                        {
                            int index = treeView1.Nodes[0].Nodes[item.Item_Type - 1].Nodes.IndexOf(node_here);
                            treeView1.Nodes[0].Nodes[item.Item_Type - 1].Nodes[index].Nodes.Remove(node_here);
                        }
                        else if (item.Item_Type <= 6)
                        {
                            int index = treeView1.Nodes[1].Nodes[item.Item_Type - 3].Nodes.IndexOf(node_here);
                            treeView1.Nodes[1].Nodes[item.Item_Type - 3].Nodes[index].Nodes.Remove(node_here);
                        }
                        else
                        {
                            int index = treeView1.Nodes[2].Nodes[item.Item_Type - 7].Nodes.IndexOf(node_here);
                            treeView1.Nodes[2].Nodes[item.Item_Type - 7].Nodes[index].Nodes.Remove(node_here);
                        }
                        treeView1.Focus();
                        treeView1.Refresh();
                        ItemsName.Remove(itemName);
                        Items.Remove(item);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        #endregion  

        // Обновление предмета
        #region updateItem

            // Обрабочтик события кнопки РЕДАКТИРОВАТЬ
            public void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
            {
                // Очистить панель
                panelClear();

                // Загрузить информацию в поля элементов управления панели
                panelDowlandInformation();
            }

            // загрузить данные в панель
            public void panelDowlandInformation()
            {
                panel1.Visible = true;
                label_TitleFunction.Text = "Редактирование";
                button_Execute.Text = "Обновить";

                updateItem = Items.Find(it => it.Item_Name == node_here.Text);
                indexName = ItemsName.IndexOf(updateItem.Item_Name);

                textBox_NameItem.Text = updateItem.Item_Name;

                comboBox_ItemType.Text = (string)comboBox_ItemType.Items[updateItem.Item_Type - 1];

                if (updateItem.Item_Type <= 2)
                {
                    textBox_AttributeName.Text = "Урон";
                }
                else if (updateItem.Item_Type <= 6)
                {
                    textBox_AttributeName.Text = "Броня";
                }
                else
                {
                    textBox_AttributeName.Visible = false;
                    comboBox_AttributeName.Visible = true;
                    comboBox_AttributeName.Text = updateItem.Attribute_Name;
                }

                numericUpDown_Value.Value = updateItem.Attribute_Indicator;
                numericUpDown_Worth.Value = updateItem.Worth;

                textBox_Description.Text = updateItem.Description;
            }

            // Обновление БД и TreeView
            public void update()
                {
                    // Проверяем заполненность элементов управления в разделе РЕДАКТИРОВАНИЕ
                    if (checkFields())
                    {
                        // Проверяем, есть ли в БД предмет с таким же именем
                        if (ItemsName.IndexOf(textBox_NameItem.Text) == -1 || ItemsName.IndexOf(textBox_NameItem.Text) == indexName)
                        {
                            // Обновление полей выбранного предмета
                            #region updateSelectedItem
                                int index = Items.IndexOf(updateItem);
                                updateItem.Item_Name = textBox_NameItem.Text;
                                updateItem.Item_Type = comboBox_ItemType.Items.IndexOf(comboBox_ItemType.SelectedItem) + 1;
                                updateItem.Attribute_Indicator = (int)numericUpDown_Value.Value;

                                if (comboBox_ItemType.SelectedIndex <= 5)
                                {
                                    updateItem.Attribute_Name = textBox_AttributeName.Text;
                                }                   
                                else
                                {
                                    updateItem.Attribute_Name = comboBox_AttributeName.Text;
                                }

                                updateItem.Worth = (int)numericUpDown_Worth.Value;
                                updateItem.Description = textBox_Description.Text;
                            #endregion

                            // Обновить выбранную ноду в TreeView
                            #region updateNode
                            Items[index] = updateItem;
                                ItemsName[indexName] = updateItem.Attribute_Name;

                                int pos_top = 0;
                                int pos_middle = 0;
                                if (updateItem.Item_Type <= 2)
                                {
                                    pos_top = 0;
                                    pos_middle = updateItem.Item_Type - 1;
                                }
                                else if (updateItem.Item_Type <= 6)
                                {
                                    pos_top = 1;
                                    pos_middle = updateItem.Item_Type - 3;

                                }
                                else
                                {
                                    pos_top = 2;
                                    pos_middle = updateItem.Item_Type - 7;
                                }

                                treeView1.Nodes[pos_top].Nodes[pos_middle].Text = updateItem.Item_Name;
                                treeView1.Nodes[pos_top].Nodes[pos_middle].Nodes[0].Text = "+" + updateItem.Attribute_Indicator + " " + updateItem.Attribute_Name;
                                treeView1.Nodes[pos_top].Nodes[pos_middle].Nodes[1].Text = updateItem.Description;
                                treeView1.Nodes[pos_top].Nodes[pos_middle].Nodes[2].Text = updateItem.Worth + " кобан";
                                treeView1.Focus();
                                treeView1.Refresh();
                            #endregion

                            // Обновление поля в БД
                            #region updateDB                  
                                try
                                {
                                    string sqlCommand = $"UPDATE Items SET [Item Name]='{updateItem.Item_Name}', [Item Type]={updateItem.Item_Type}, " +
                                                        $"[Attribute Indicator]={updateItem.Attribute_Indicator}, [Attribute name]='{updateItem.Attribute_Name}', " +
                                                        $"Description='{updateItem.Description}', Worth={updateItem.Worth} WHERE [ID Item]={updateItem.ID_Item}";
                                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                                    {
                                        command.ExecuteNonQuery();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            #endregion

                            // Скрытие раздела РЕДАКТИРОВАНИЕ
                            panelClear();
                        }
                        else
                        {
                            MessageBox.Show("Имя с таким полем уже существует", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        #endregion

        // Добавление предмета
        #region createItem

            // Обрабочтик события кнопки ДОБАВИТЬ
            private void добавитьПредметToolStripMenuItem_Click(object sender, EventArgs e)
            {
                panelClear();

                label_TitleFunction.Text = "Добавление";
            }

            // Создание нового предмета
            public void create()
            {
                // Проверяем заполненность элементов управления в разделе ДОБАВЛЕНИЕ
                if (checkFields())
                {
                    // Проверяем, есть ли в БД предмет с таким же именем
                    if (ItemsName.IndexOf(textBox_NameItem.Text) == -1)
                    {
                        // Создание нового предмета
                        #region newItem
                        Item item = new Item();
                        item.ID_Item = Items[Items.Count - 1].ID_Item + 1;
                        item.Item_Name = textBox_NameItem.Text;
                        item.Item_Type = comboBox_ItemType.Items.IndexOf(comboBox_ItemType.SelectedItem) + 1;
                        item.Attribute_Indicator = (int)numericUpDown_Value.Value;

                        if (comboBox_ItemType.SelectedIndex <= 5)
                        {
                            item.Attribute_Name = textBox_AttributeName.Text;
                        }
                        else
                        {
                            item.Attribute_Name = comboBox_AttributeName.Text;
                        }

                        item.Description = textBox_Description.Text;
                        item.Worth = (int)numericUpDown_Worth.Value;

                        Items.Add(item);
                        ItemsName.Add(item.Item_Name);
                        #endregion

                        // Создание новой ноды TreeView
                        #region newNode
                        TreeNode node = new TreeNode(item.Item_Name);

                        string attribute = "+" + item.Attribute_Indicator + " " + item.Attribute_Name;
                        node.Nodes.Add(attribute);

                        node.Nodes.Add(item.Description);
                        string worth = item.Worth + " кобан";
                        node.Nodes.Add(worth);

                        if (Convert.ToInt32(item.Item_Type) <= 2)
                        {
                            treeView1.Nodes[0].Nodes[Convert.ToInt32(item.Item_Type) - 1].Nodes.Add(node);
                        }
                        else if (Convert.ToInt32(item.Item_Type) <= 6)
                        {
                            treeView1.Nodes[1].Nodes[Convert.ToInt32(item.Item_Type) - 3].Nodes.Add(node);
                        }
                        else
                        {
                            treeView1.Nodes[2].Nodes[Convert.ToInt32(item.Item_Type) - 7].Nodes.Add(node);
                        }
                        #endregion

                        // Создание новой записи в БД
                        #region newFieldBD
                            try
                            {
                                string sqlCommand = $"INSERT INTO Items ([Item Name], [Item Type], [Attribute indicator], [Attribute name], Descripton, Worth) " +
                                                    $"VALUES ('{item.Item_Name}', {item.Item_Type}, {item.Attribute_Indicator}, '{item.Attribute_Name}', '{item.Description}', {item.Worth})";
                                               
                                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                                {
                                    command.ExecuteNonQuery();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        #endregion

                        panelClear();
                    }
                    else
                    {
                        MessageBox.Show("Имя с таким полем уже существует", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        #endregion

        // Работа с панелью
        #region WorhWirhPanel
            
            // Прорерка на заполненность всех панелей управления панели
            public bool checkFields()
            {
                if (textBox_NameItem.TextLength == 0) return false;           
                if (textBox_AttributeName.TextLength == 0 || comboBox_AttributeName.Text.Length == 0) return false;
                if (comboBox_ItemType.Text.Length == 0) return false;
                if (textBox_Description.TextLength == 0) return false;

                return true;
            }

            // Очистить элементы управления панели
            public void panelClear()
            {
                textBox_NameItem.Text = "";
                textBox_AttributeName.Text = "";
                textBox_Description.Text = "";
                comboBox_ItemType.Text = "";
                comboBox_AttributeName.Text = "";
                numericUpDown_Value.Value = 1;
                numericUpDown_Worth.Value = 1;

                textBox_AttributeName.Visible = true;
                comboBox_AttributeName.Visible = false;
                panel1.Visible = false;
            }

        #endregion

        //  Обработчики событий элемента управления формы
        #region WorkWithForm

            // Обработчик событий TreeView при нажатии правой кнопкой на node
            public void treeView1_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button != MouseButtons.Right) return;

                node_here = treeView1.GetNodeAt(e.X, e.Y);
                if (node_here == null) return;

                if (Types.IndexOf(node_here.Text) != -1)
                {
                    TypeStripMenu.Show(treeView1, e.Location);
                }
                if (ItemsName.IndexOf(node_here.Text) != -1)
                {
                    ItemStripMenu.Show(treeView1, e.Location);
                }
            }

            // Обработчик события кнопки ВЫХОД
            public void button_Exit_Click(object sender, EventArgs e)
            {
                connection.Close();
                Application.Exit();
            }

            // Обработчик события кнопки ВЫПОЛНИТЬ
            public void button_Execute_Click(object sender, EventArgs e)
            {

                if (label_TitleFunction.Text == "Редактирование")
                {
                    update();
                }
                if (label_TitleFunction.Text == "Добавление")
                {
                    create();
                }
            }

            // Обработчик события кнопки ОТМЕНА
            public void button_Cancel_Click(object sender, EventArgs e)
            {
                panelClear();
            }

            // Обработчик события при изменение выбранного типа предмета в comboBox_ItemType
            public void comboBox_ItemType_TextChanged(object sender, EventArgs e)
            {
                if (comboBox_ItemType.SelectedIndex <= 1)
                {
                    textBox_AttributeName.Visible = true;
                    comboBox_AttributeName.Visible = false;
                    textBox_AttributeName.Text = "Урон";
                }
                else if (comboBox_ItemType.SelectedIndex <= 5)
                {
                    textBox_AttributeName.Visible = true;
                    comboBox_AttributeName.Visible = false;
                    textBox_AttributeName.Text = "Броня";
                }
                else
                {
                    textBox_AttributeName.Visible = false;
                    comboBox_AttributeName.Visible = true;
                    comboBox_AttributeName.Text = (string)comboBox_AttributeName.Items[0];
                }
            }
        
        #endregion
    }
}