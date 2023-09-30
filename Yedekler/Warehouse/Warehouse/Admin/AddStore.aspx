<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="AddStore.aspx.cs" Inherits="Warehouse.Admin.AddStore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
          <div style=" background-color:#4C72DE" class="card-header">
           <h3 style="text-align:center">Add Store</h3>
       </div>
    </div>
    <div class="card-body">
        <div class="row">
             <div class="col-xl-10">
                         <label class="form-label">Store Name</label>
                        <asp:TextBox ID="tb_name" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>
             <div class="col-xl-2">
                 <div class="mt-2"></div>
                         <label class="form-label">Activity</label>
                        <asp:CheckBox ID="cb_activity" runat="server" CssClass="form-check"></asp:CheckBox>
                     </div>
        </div>
        <div class="row">
            <div class="mt-5">
             <asp:Button runat="server" ID="btn_add" OnClick="btn_add_Click" CssClass="btn btn-primary form-control " Text="Add Store" />
                </div>
        </div>
    </div>
</asp:Content>
