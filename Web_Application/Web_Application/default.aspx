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
    .btn_tile {
        background-color: white;
        opacity: 0.5;
        border: 1px solid #fff;
        padding: 10px;
        height:100px;
        width:100px;
    }
        .btn_tile:hover {
            background-color: #72c2a2;
            opacity: 1;
        }
    .btn_tile_clicked {
        background-color: white;
        opacity: 1;
        border: 1px solid #fff;
        padding: 10px;
        height:100px;
        width:100px;
    }

</style>

    <ul>
        <li id="page_home">
            <form id="form1" runat="server" style="background:none">
                <div class="container_16">
                    <div class="grid_6">
                        <div class="slogan">
                            <p>Find<br/>what you<br/>need</p>
                        </div>
                    </div>
                    <div class="grid_6 pull_2">      
                        <asp:TextBox ID="TxtB_Input" runat="server" CssClass="inputTxt"></asp:TextBox>
                        <asp:Button ID="Btn_Search" runat="server" Text="Search" OnClick="Btn_Search_Click" CssClass="btn_search" />
                    </div>
                    <div class="grid_4 push_2">
                        <input id="Hidden1" type="hidden" runat="server" />
                        <input id="tl_news" type="button" value="News" class="btn_tile" onclick="context_clicked(this.value)"/>&nbsp;&nbsp;&nbsp;&nbsp;
                        <input id="tl_sports" type="button" value="Sports" class="btn_tile" onclick="context_clicked(this.value)"/><br />
                        <br />
                        <input id="tl_music" type="button" value="Music" class="btn_tile" onclick="context_clicked(this.value)"/>&nbsp;&nbsp;&nbsp;&nbsp;
                        <input id="tl_person" type="button" value="Person" class="btn_tile" onclick="context_clicked(this.value)"/><br />
                        <br />
                        <input id="tl_country" type="button" value="Country" class="btn_tile" onclick="context_clicked(this.value)"/>&nbsp;&nbsp;&nbsp;&nbsp;
                        <input id="tl_technology" type="button" value="Technology" class="btn_tile" onclick="context_clicked(this.value)"/>
                        <script type="text/javascript">

                            var btn_tile = document.getElementsByClassName('btn_tile');

                            for (var i = 0; i < btn_tile.length; i++) {
                                btn_tile[i].addEventListener('click', function () {
                                    if (this.getAttribute('class') == 'btn_tile') {
                                        this.setAttribute('class', 'btn_tile_clicked');
                                    } else {
                                        this.setAttribute('class', 'btn_tile');
                                    }
                                });
                            }

                            function context_clicked(click_id) {
                                var hidden = document.getElementById("<%:Hidden1.ClientID%>").value;
                                if (hidden.search(click_id) == -1) {
                                    document.getElementById("<%:Hidden1.ClientID%>").value += "%" + click_id;
                                } else {
                                    hidden = hidden.replace("%" + click_id, "");
                                    document.getElementById("<%:Hidden1.ClientID%>").value = hidden;
                                }
                            }

                        </script>
                    </div>
                </div>
            </form>
        </li>
    </ul >
</asp:Content>
