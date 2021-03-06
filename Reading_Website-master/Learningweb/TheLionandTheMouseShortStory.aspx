<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TheLionandTheMouseShortStory.aspx.cs" Inherits="Learningweb.TheLionandTheMouseShortStory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 700px;
            height: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Height="33px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" style="text-align: center; font-weight: 700; background-color: #99FFCC;">
                <asp:ListItem>Select color</asp:ListItem>
                <asp:ListItem>Black</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Purple</asp:ListItem>
                <asp:ListItem>Orange</asp:ListItem>
                <asp:ListItem>Yellow</asp:ListItem>
            </asp:DropDownList>
        &nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" style="font-weight: 700; font-style: italic; color: #000000; background-color: #CC99FF">
                <asp:ListItem>Font Size</asp:ListItem>
                <asp:ListItem>xx-small</asp:ListItem>
                <asp:ListItem>x-small</asp:ListItem>
                <asp:ListItem>small</asp:ListItem>
                <asp:ListItem>Medium</asp:ListItem>
                <asp:ListItem>large</asp:ListItem>
                <asp:ListItem>x-large</asp:ListItem>
                <asp:ListItem>xx-large</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <br />
                    <asp:Label ID="Label20" runat="server" Text="00:00"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <h2>
                <asp:Label ID="Nstory" runat="server" style="text-align: left; font-weight: 700" Text="The Lion and The Mouse "></asp:Label>
            </h2>
        </div>
        <div style="text-align: center">
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/1.jpg" /><br />
            <asp:Label ID="Label1" runat="server" Text="lets start reading"></asp:Label>
            <strong><em><br />
            </em></strong>
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/2.jpg" /><br />
            <asp:Label ID="Label2" runat="server" Text="There was a beautiful forest."></asp:Label>
            <br />
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/3.jpg" /><br />
            <asp:Label ID="Label3" runat="server" Text="There lived a mouse near a lion's cage."></asp:Label>
            <br />
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/4.jpg" /><br />
            <asp:Label ID="Label4" runat="server" Text="The mouse was very playful."></asp:Label>
            <br />
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/5.jpg" /><br />
            <asp:Label ID="Label5" runat="server" Text="One day the mouse went to lion's cage."></asp:Label>
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/6.jpg" /><br />
            <asp:Label ID="Label6" runat="server" Text="Without knowing the lion's power it started to play over the lion."></asp:Label>
            <br />
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/7.jpg" /><br />
            <asp:Label ID="Label7" runat="server" Text="Lion suddenly woke up. It got angry and began to roar loudly."></asp:Label>
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/8.jpg" /><br />
            <asp:Label ID="Label8" runat="server" Text="Lion caught the mouse and threatened that he would eat him."></asp:Label>
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/9.jpg" /><br />
            <asp:Label ID="Label9" runat="server" Text="Mouse said sorry and pleaded the lion to leave him without eating."></asp:Label>
            <br />
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/10.jpg" /><br />
            <asp:Label ID="Label10" runat="server" Text="The lion took pity and let the mouse to go."></asp:Label>
            <br />
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/11.jpg" /><br />
            <asp:Label ID="Label11" runat="server" Text="Two days later, a hunter came to the forest."></asp:Label>
            <br />
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/12.jpg" /><br />
            <asp:Label ID="Label12" runat="server" Text="The hunter saw the lion and trapped it using his net."></asp:Label>
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/13.jpg" /><br />
            <asp:Label ID="Label13" runat="server" Text="The hunter went to his village to find more people to kill the lion. Lion kept shouting for help."></asp:Label>
            <br />
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/14.jpg" /><br />
            <asp:Label ID="Label14" runat="server" Text="Mouse heard lion's cries and came to help him. It cut the net in to pieces and freed the lion."></asp:Label>
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/15.jpg" /><br />
            <asp:Label ID="Label15" runat="server" Text="Finally, the lion escaped from the net."></asp:Label>
            <br />
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/16.jpg" /><br />
            <br />
            <asp:Label ID="Label16" runat="server" Text="The lion thanked the mouse for his help. Then, they two started to live as friends forever."></asp:Label>
            <br />
            <img alt="" class="auto-style1" src="images%20(2)/The%20Lion%20and%20The%20Mouse%20Short%20Story/17.jpg" /><br />
            <br />
            <asp:Label ID="Label19" runat="server" Text="Please rate the story First enter your Identity"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList4" runat="server">
                <asp:ListItem Value="Rating"></asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>**</asp:ListItem>
                <asp:ListItem>***</asp:ListItem>
                <asp:ListItem>****</asp:ListItem>
                <asp:ListItem>*****</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send rate" />
            <br />
            <br />
            <asp:Label ID="Label18" runat="server" Text="."></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
