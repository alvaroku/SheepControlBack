namespace Shared
{
    public class EmailTemplateConstants
    {
        public const string plantillaEmailRecoveryPassword = @"
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset='UTF-8'>
        <title>Sheep Control</title>
    </head>
<style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            padding: 20px;
        }

        h1 {
            color: #333333;
        }

        p {
            color: #666666;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #007bff;
            color: #ffffff;
            text-decoration: none;
            border-radius: 4px;
        }
    </style>
    <body>
        <h1>¡Hola! {name}</h1>
        <p>Haz solicitado la recuperación de tu contraseña.</p>
        <p>Por lo tanto, hemos generado una contraseña temporal para que puedas acceder al sistema y cambiarla por una que tu elijas.</p>
        <p>La contraseña temporal es: {password}</p>
<a href=""{url}"" class=""button"">Iniciar sesión</a>
    </body>
    </html>
";
        public static string plantillaEmailDataAccess = @"
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset='UTF-8'>
        <title>Sheep Control</title>
    </head>
<style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            padding: 20px;
        }

        h1 {
            color: #333333;
        }

        p {
            color: #666666;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #007bff;
            color: #ffffff;
            text-decoration: none;
            border-radius: 4px;
        }
    </style>
    <body>
        <h1>¡Hola! {name}</h1>
        <p>Bienvenido a Sheep Control</p>
<p>{message}</p>
<p>Correo: {email}</p>
        <p>Contraseña: {password}</p>
<a href=""{url}"" class=""button"">Iniciar sesión</a>
    </body>
    </html>
";


        public const string plantillaEmailChanged = @"
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset='UTF-8'>
        <title>Sheep Control</title>
    </head>
<style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            padding: 20px;
        }

        h1 {
            color: #333333;
        }

        p {
            color: #666666;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #007bff;
            color: #ffffff;
            text-decoration: none;
            border-radius: 4px;
        }
    </style>
    <body>
        <h1>¡Hola! {name}</h1>
        <p>Bienvenido a Sheep Control</p>
<p>{message}</p>
        <p>De ahora en adelante este será tu corrreo para acceder al sistema.</p>
<a href=""{url}"" class=""button"">Iniciar sesión</a>
    </body>
    </html>
";
    }
}
