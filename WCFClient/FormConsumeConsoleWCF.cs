using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WCFClient
{
    public partial class FormConsumeConsoleWCF : Form
    {
        public FormConsumeConsoleWCF()
        {
            InitializeComponent();
        }

        //启动了host服务后：

        //若自己写client测试：
        //打开vs cmd，定位到client文件夹
        //cd C:\WCFDemo\WCFClient
        //svcutil http://localhost:8000/?wsdl /o:FirstServiceClient.cs
        //执行成功后，会在解决方案目录下生成两个文件：FirstServiceClient.cs 和output.config
        //中止Host项目的调试，回到Client项目，选择添加 现有项 ，然后选择这两个文件，添加后，将output.config重命名为App.config
        //Client项目中添加引用，选择System.ServiceModel

        ConsoleUserService.UserServiceClient userClient = new ConsoleUserService.UserServiceClient();
        ConsoleRoleService.RoleServiceClient roleClient = new ConsoleRoleService.RoleServiceClient();



        private void button1_Click(object sender, EventArgs e)
        {

            ConsoleUserService.UserInfo user = userClient.GetUser((this.textBox1.Text));
            MessageBox.Show(user.Name + "--" + user.Id);

            MessageBox.Show(roleClient.GetUser(5).Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userClient.Show();
        }
    }
}
