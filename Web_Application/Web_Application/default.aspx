<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web_Application._default" MasterPageFile ="~/WebbApp.Master" %>


<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
<style type="text/css">
     .inputTxt {
         margin-top: 216px;
         height:30px;
         width: 550px;
     }
    .btn_search {
        margin-left:235px;
        margin-right:auto;
        margin-top:5px;
        height:18px;
        width:80px;
    }
</style>
    <ul>
        <li id="page_home">
            <div class="container_16">
                <div class="grid_6">
                    <div class="slogan">
                        <p>Find<br/>what you<br/>need</p>
                    </div>
                </div>
                 <div class="grid_10 pull_2">
                     <form id="form1" runat="server">
                         <asp:TextBox ID="TxtB_Input" runat="server" CssClass="inputTxt"></asp:TextBox>
                         <asp:Button ID="Btn_Search" runat="server" Text="Search" OnClick="Btn_Search_Click" CssClass="btn_search" />
                     </form>
                 </div>
            </div>
        </li>
     </ul>
</asp:Content>
