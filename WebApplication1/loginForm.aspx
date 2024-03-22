<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginForm.aspx.cs" Inherits="WebApplication1.loginForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="container">
     <div class="row">
         <div class="col-md-6 mx-auto">
             <div class="card">
                 <div calss="card-body">
                     <div class="row">
                         <div class="col">
                             <center>
                                 <img src="imgs/sign-up.png" width="150" />
                             </center>
                         </div>
                     </div>
                     <div class="row">
                         <div class="col">
                             <center>
                                 <h3>User Login</h3>
                             </center>
                         </div>
                     </div>
                     <div class="row">
                         <div class="col">

                             <hr />
                         </div>
                     </div>
                     <div class="row">
                         <div class="col">
                             <div class="form-group">
                                 <label>Username </label>
                                 <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="Enter Your Username"></asp:TextBox>
                                 <br />
                                 <label>Password</label>
                                 <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" placeholder="Enter Your Password" TextMode="Password"></asp:TextBox>

                             </div>
                             <div class="form-group">
                                 <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="login" OnClick="Button1_Click" />
                             </div>
                             <div class="form-group">
                                 <br />

                             </div>

                         </div>
                     </div>

                 </div>

             </div>

         </div>

     </div>

 </div>






    <%-- <Label>Username</Label>
 <asp:TextBox ID="TextBox1" placeholder="Enter your Username" runat="server"></asp:TextBox><br />
 <Label>Password</Label>
 <asp:TextBox ID="TextBox2" TextMode="Password" placeholder="Enter your Password" runat="server"></asp:TextBox> <br />
 <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="SignUp" OnClick="Button2_Click" />--%>

</asp:Content>
