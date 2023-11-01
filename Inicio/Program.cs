namespace Inicio
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var exit = false;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            while (!exit)
            {
                var loginForm = new Login();
                Application.Run(loginForm);
                if (loginForm.DialogResult==DialogResult.OK) // Reemplaza por la lógica de autenticación apropiada
                {
                    var inicioForm = new Inicio(loginForm.Usuario, loginForm.Persona);
                    Application.Run(inicioForm);
                    if (inicioForm.DialogResult == DialogResult.Abort) exit = true;
                } else exit = true;
            }
        }
    }
}