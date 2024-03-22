<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sign_up.aspx.cs" Inherits="WebApplication1.sign_up" %>

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
                                    <img src="imgs/generaluser.png" width="150" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>User Signup</h3>
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
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="SignUp" OnClick="Button1_Click" />
                                </div>
                               
                            </div>
                        </div>

                    </div>

                </div>

            </div>

        </div>

    </div>



</asp:Content>
