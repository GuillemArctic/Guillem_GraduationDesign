<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainRegister.aspx.cs" Inherits="MainRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>项目实施管理系统</title>
    <!-- Place favicon.ico and apple-touch-icon.png in the root directory -->
    <link rel="shortcut icon" href="favicon.ico" />
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,700,300' rel='stylesheet' type='text/css' />
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/animate.css" />
    <link rel="stylesheet" href="css/style.css" />

    <!-- Modernizr JS -->
    <script src="js/modernizr-2.6.2.min.js"></script>

</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-md-12 text-center">
                <ul class="menu">
                    <li class="active"><a href="index.html">项目实施管理系统</a></li>
                </ul>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <!-- Start Sign In Form -->
                <form class="fh5co-form animate-box" data-animate-effect="fadeIn">
                    <h2>注册账号</h2>
                    <div class="form-group">
                        <label for="name" class="sr-only">姓名</label>
                        <input type="text" class="form-control" id="name" placeholder="姓名" autocomplete="off" />
                    </div>
                    <div class="form-group">
                        <label for="name" class="sr-only">性别</label>
                        <input type="text" class="form-control" id="sex" placeholder="性别" autocomplete="off" />
                    </div>
                    <div class="form-group">
                        <label for="name" class="sr-only">手机号码</label>
                        <input type="text" class="form-control" id="phone" placeholder="手机号码" autocomplete="off" />
                    </div>
                    <div class="form-group">
                        <label for="name" class="sr-only">身份证号码</label>
                        <input type="text" class="form-control" id="cardid" placeholder="身份证号码" autocomplete="off" />
                    </div>
                    <div class="form-group">
                        <label for="email" class="sr-only">邮箱地址</label>
                        <input type="email" class="form-control" id="email" placeholder="邮箱地址" autocomplete="off" />
                    </div>
                    <div class="form-group">
                        <label for="password" class="sr-only">密码</label>
                        <input type="password" class="form-control" id="password" placeholder="密码" autocomplete="off" />
                    </div>
                    <div class="form-group">
                        <label for="re-password" class="sr-only">确认密码</label>
                        <input type="password" class="form-control" id="re-password" placeholder="确认密码" autocomplete="off" />
                    </div>
                    <div class="form-group">
                        <input type="submit" value="提交" class="btn btn-primary" onclick="SubmitClick()" />
                    </div>
                </form>
                <!-- END Sign In Form -->

            </div>
        </div>
        <div class="row" style="padding-top: 60px; clear: both;">
            <div class="col-md-12 text-center">
                <p><small>&copy; All Rights Reserved. More Templates</small></p>
            </div>
        </div>
    </div>

    <script>
        //提交注册信息
        function SubmitClick() {
            var name = $("#name").val();
            var sex = $("#sex").val();
            var phone = $("#phone").val();
            var cardid = $("#cardid").val();
            var email = $("#email").val();
            var password = $("#password").val();
            var repassword = $("#re-password").val();
            $.ajax({
                type: "POST",
                url: "RegisterHelper.ashx",
                data: "RegisterMessage=" + name + "#" + sex + "#" + phone + "#" + cardid + "#" + email + "#" + password + "#" + repassword,
                success: function (data) {
                    alert(data);
                }
            })
        }
    </script>
    <!-- jQuery -->
    <script src="js/jquery.min.js"></script>
    <!-- Bootstrap -->
    <script src="js/bootstrap.min.js"></script>
    <!-- Placeholder -->
    <script src="js/jquery.placeholder.min.js"></script>
    <!-- Waypoints -->
    <script src="js/jquery.waypoints.min.js"></script>
    <!-- Main JS -->
    <script src="js/main.js"></script>
</body>
</html>
