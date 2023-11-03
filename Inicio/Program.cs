namespace Inicio
{
    internal static class Program
    {
        const string administrador = "Administrador";
        const string docente = "Docente";
        const string alumno = "Alumno";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var fondo = new Fondo();
            Application.Run(fondo);
            fondo.IniciarAplicacion();
            //while (!exit)
            //{
            //    var loginForm = new Login();
            //    Application.Run(loginForm);
            //    if (loginForm.DialogResult==DialogResult.OK)
            //    {
            //        Form? form = null;
            //        switch (loginForm.tipoIngreso)
            //        {
            //            case alumno:
            //                exit = true;
            //                break;
            //            case administrador:
            //                form = new Inicio();
            //                break;
            //            case docente:
            //                exit = true;
            //                break;
            //            default:
            //                break;
            //        }
            //        if (form is not null) Application.Run(form);
            //        if (form.DialogResult == DialogResult.Abort) exit = true;
            //    } else exit = true;
            //}
        }
    }
}