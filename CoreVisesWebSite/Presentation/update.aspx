<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="update.aspx.vb" Inherits="CoreVisesWebSite.update" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
    <link rel="stylesheet" href="../css/font-awesome-4.6.3/css/font-awesome.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="account-in">
        <div class="container">
            <form id="update_Client" class="form-horizontal center-block" runat="server" style="margin-left: 25%;">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <!-- No seleccionó opción -->
                        <div id="dontSelect" runat="server">
                            <h2>Please select the option you want to update</h2>
                        </div>
                        <!-- Información Personal -->
                        <div id="uPersonal" runat="server">
                            <h2>Personal Information</h2>
                            <!-- Nombre -->
                            <div class="form-group">
                                <asp:Label ID="lblFirstName" CssClass="control-label col-sm-2" runat="server"
                                     Text="Name:" AssociatedControlID="txtFirstName"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtFirstName" runat="server" MaxLength="30" 
                                        CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ErrorMessage="Write the name" 
                                        ControlToValidate="txtFirstName" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revFirstName" runat="server" ErrorMessage="You can only write letters"
                                        ValidationExpression="^[a-zA-Z]*$" ControlToValidate="txtFirstName" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <!-- 1er Apellido -->
                            <div class="form-group">
                                <asp:Label ID="lblFirstLastName" CssClass="control-label col-sm-2" runat="server"
                                    Text="First Last Name:" AssociatedControlID="txtFirstLastName"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtFirstLastName" runat="server" MaxLength="40"
                                        CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvFirstLastName" runat="server" ErrorMessage="Write the first last name" 
                                        ControlToValidate="txtFirstLastName" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revFirstLastName" runat="server" ErrorMessage="You can only write letters"
                                        ValidationExpression="^[a-zA-Z]*$" ControlToValidate="txtFirstLastName" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <!-- 2do Apellido -->
                            <div class="form-group">
                                <asp:Label ID="lblSecondLastName" CssClass="control-label col-sm-2" runat="server" 
                                    Text="Second Last Name:" AssociatedControlID="txtSecondLastName"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtSecondLastName" runat="server" MaxLength="40"
                                        CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvSecondLastName" runat="server" ErrorMessage="Write the second last name" 
                                        ControlToValidate="txtSecondLastName" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revSecondLastName" runat="server" ErrorMessage="You can only write letters"
                                        ValidationExpression="^[a-zA-Z]*$" ControlToValidate="txtSecondLastName" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <!-- Email -->
                            <div class="form-group">
                                <asp:Label ID="lblEmail" CssClass="control-label col-sm-2" runat="server" 
                                    Text="Email:" AssociatedControlID="txtEmail"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtEmail" MaxLength="100" TextMode="Email" runat="server"
                                        CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Write the email" 
                                        ControlToValidate="txtEmail" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div><!-- Información Personal -->
                        <!-- Información de dirección -->
                        <div id="uAddress" runat="server">
                            <h2>Address Information</h2>
                            <!-- Código Postal -->
                            <div class="form-group">
                                <asp:Label ID="lblPostalCode" CssClass="control-label col-sm-2" runat="server" 
                                    Text="Postal Code:" AssociatedControlID="txtPostalCode"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtPostalCode" MaxLength="5" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPostalCode" runat="server" ErrorMessage="Write the postal code" 
                                        ControlToValidate="txtPostalCode" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revPostalCode" runat="server" ErrorMessage="You can only write numbers, and with a length of 5 characters"
                                        ValidationExpression="^[0-9]{5}$" ControlToValidate="txtPostalCode" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <!-- Dirección -->
                            <div class="form-group">
                                <asp:Label ID="lblAddressDirection" CssClass="control-label col-sm-2" runat="server" 
                                    Text="Address direction:" AssociatedControlID="txtAddressDirection"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtAddressDirection" MaxLength="200" runat="server"
                                        CssClass="form-control" TextMode="MultiLine" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvAddressDirection" runat="server" ErrorMessage="Write the address direction" 
                                        ControlToValidate="txtAddressDirection" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div><!-- Información de dirección -->
                        <!-- Información de la tarjeta -->
                        <div id="uCard" runat="server">
                            <h2>Card Information</h2>
                            <!-- Número de la tarjeta -->
                            <div class="form-group">
                                <asp:Label ID="lblNumberCard" CssClass="control-label col-sm-2" runat="server" 
                                    Text="Number Card:" AssociatedControlID="txtNumberCard"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtNumberCard" MaxLength="16" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvNumberCard" runat="server" ErrorMessage="Write the number card" 
                                        ControlToValidate="txtNumberCard" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revNumberCard" runat="server" ErrorMessage="You can only write numbers, and with a length of 16 characters"
                                        ValidationExpression="^[0-9]{16}$" ControlToValidate="txtNumberCard" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <!-- svc de la tarjeta -->
                            <div class="form-group">
                                <asp:Label ID="lblsvcCard" CssClass="control-label col-sm-2" runat="server" 
                                    Text="SVC Card:" AssociatedControlID="txtsvcCard"></asp:Label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtsvcCard" MaxLength="3" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvsvcCard" runat="server" ErrorMessage="Write the svc card" 
                                        ControlToValidate="txtsvcCard" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revsvcCard" runat="server" ErrorMessage="You can only write numbers, and with a length of 3 characters"
                                        ValidationExpression="^[0-9]{3}$" ControlToValidate="txtsvcCard" 
                                        Display="Dynamic" CssClass="alert alert-danger"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                        </div><!-- Información de la tarjeta -->
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-default" OnClick="btnUpdate_Click"/>
                            </div>
                        </div>
                        <div id="exitMessage" runat="server">
                            <div class="form-group">
                                <div class="alert alert-success col-sm-offset-2" style="width:42%">
                                    <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                    Successfully updated
                                </div>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                    <ProgressTemplate>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <i class="fa fa-spinner fa-pulse fa-3x fa-fw"></i>
                                <span class="sr-only">Loading...</span>
                            </div>
                        </div>
                    </ProgressTemplate>
                </asp:UpdateProgress>
            </form>
        </div><!-- Fin del DIV container -->
    </div> <!-- Fin del DIV account-in -->
</asp:Content>