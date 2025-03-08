using LogicaObligatorioP2_De_gregorio_y_Echenique;
using ObligatorioP2_De_Gregorio_y_Echenique;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObligatorioP2_De_Gregorio_y_Echenique
{
    //Inicialización de las listas con sus respectivos atributos get
    public class Sistema
    {
        private static Sistema s_instancia; // Punto 1 Patron singleton
        private List<Empleado> _empleados = new List<Empleado>();
        private List<Animal> _animales = new List<Animal>();
        private List<Vacuna> _vacunas = new List<Vacuna>();
        private List<Potrero> _potreros = new List<Potrero>();  
        private List<Tarea> _tareasAsignadas = new List<Tarea>();
        private List<RegistroVacunacion> _registrosVacunaciones = new List<RegistroVacunacion>();

        //Punto 2 - Patron singleton
        public static Sistema Instancia
        {
            get
            {
                if (s_instancia == null)
                {
                    s_instancia = new Sistema();
                }
                return s_instancia;
            }
        }
        public List<Empleado> Empleados
        {
            get { return _empleados; }
        }
        public List<Vacuna> Vacunas
        {
            get { return _vacunas; }
        }

        public List<Animal> Animales
        {
            get { return _animales; }
        }

        public List<Potrero> Potreros
        {
            get { return _potreros; }
        }

        public List<Tarea> Tareas
        {
            get { return _tareasAsignadas; }
        }

        public List<RegistroVacunacion> RegistroVacunaciones
        {
            get { return _registrosVacunaciones; }
        }

        //Llamada de los métodos que precargan los datos
        private Sistema()
        {
            PreCargarPeon();
            PreCargarCapataz();
            PreCargarVacunas();
            PreCargarPotreros();
            PreCargarBovinos();
            PreCargarOvinos();
            AsignarAnimalesPotreros();
            PreCargarTareas();
            PreCargarRegistroVacunacion();
        }

        //Precarga de bovinos
        private void PreCargarBovinos()
        {
            AltaBovino(new Bovino("B0000001", "Macho", "Holstein", new DateTime(2022, 04, 15), 1200, 145, 300, false, "Pastura"));
            AltaBovino(new Bovino("B0000002", "Hembra", "Jersey", new DateTime(2017, 07, 22), 950, 230, 400, true, "Grano"));
            AltaBovino(new Bovino("B0000003", "Macho", "Angus", new DateTime(2018, 01, 01), 1300, 190, 450, false, "Pastura"));
            AltaBovino(new Bovino("B0000004", "Hembra", "Holstein", new DateTime(2020, 03, 09), 1100, 175, 350, true, "Grano"));
            AltaBovino(new Bovino("B0000005", "Macho", "Jersey", new DateTime(2019, 05, 05), 1000, 215, 500, false, "Pastura"));
            AltaBovino(new Bovino("B0000006", "Hembra", "Angus", new DateTime(2016, 12, 12), 1400, 205, 620, true, "Grano"));
            AltaBovino(new Bovino("B0000007", "Macho", "Holstein", new DateTime(2017, 08, 28), 800, 180, 290, false, "Pastura"));
            AltaBovino(new Bovino("B0000008", "Hembra", "Jersey", new DateTime(2021, 02, 03), 1050, 250, 410, true, "Grano"));
            AltaBovino(new Bovino("B0000009", "Macho", "Angus", new DateTime(2018, 06, 20), 1250, 160, 470, false, "Pastura"));
            AltaBovino(new Bovino("B0000010", "Hembra", "Holstein", new DateTime(2019, 11, 10), 900, 220, 340, false, "Grano"));
            AltaBovino(new Bovino("B0000011", "Hembra", "Angus", new DateTime(2018, 10, 04), 950, 140, 380, true, "Pastura"));
            AltaBovino(new Bovino("B0000012", "Macho", "Jersey", new DateTime(2020, 06, 15), 850, 255, 420, false, "Grano"));
            AltaBovino(new Bovino("B0000013", "Hembra", "Holstein", new DateTime(2019, 02, 28), 1150, 210, 330, true, "Pastura"));
            AltaBovino(new Bovino("B0000014", "Macho", "Angus", new DateTime(2016, 07, 07), 1050, 260, 510, false, "Grano"));
            AltaBovino(new Bovino("B0000015", "Hembra", "Jersey", new DateTime(2021, 03, 13), 1250, 195, 290, true, "Pastura"));
            AltaBovino(new Bovino("B0000016", "Macho", "Holstein", new DateTime(2017, 09, 21), 1400, 165, 540, false, "Grano"));
            AltaBovino(new Bovino("B0000017", "Hembra", "Angus", new DateTime(2018, 01, 29), 1300, 240, 460, false, "Pastura"));
            AltaBovino(new Bovino("B0000018", "Macho", "Jersey", new DateTime(2019, 04, 05), 900, 285, 350, true, "Grano"));
            AltaBovino(new Bovino("B0000019", "Hembra", "Holstein", new DateTime(2020, 12, 10), 980, 275, 310, false, "Pastura"));
            AltaBovino(new Bovino("B0000020", "Macho", "Angus", new DateTime(2016, 08, 18), 1100, 155, 550, true, "Grano"));
            AltaBovino(new Bovino("B0000021", "Hembra", "Holstein", new DateTime(2019, 11, 09), 1070, 200, 360, false, "Grano"));
            AltaBovino(new Bovino("B0000022", "Macho", "Jersey", new DateTime(2018, 02, 14), 920, 135, 400, true, "Pastura"));
            AltaBovino(new Bovino("B0000023", "Hembra", "Angus", new DateTime(2017, 05, 21), 1250, 300, 470, false, "Grano"));
            AltaBovino(new Bovino("B0000024", "Macho", "Holstein", new DateTime(2020, 07, 31), 1150, 185, 430, true, "Pastura"));
            AltaBovino(new Bovino("B0000025", "Hembra", "Jersey", new DateTime(2016, 08, 18), 850, 270, 410, false, "Grano"));
            AltaBovino(new Bovino("B0000026", "Macho", "Angus", new DateTime(2018, 12, 03), 1000, 150, 350, true, "Pastura"));
            AltaBovino(new Bovino("B0000027", "Hembra", "Holstein", new DateTime(2020, 01, 06), 1100, 225, 520, false, "Grano"));
            AltaBovino(new Bovino("B0000028", "Macho", "Jersey", new DateTime(2024, 06, 15), 940, 290, 480, true, "Pastura"));
            AltaBovino(new Bovino("B0000029", "Hembra", "Angus", new DateTime(2024, 06, 16), 1300, 265, 500, false, "Grano"));
            AltaBovino(new Bovino("B0000030", "Macho", "Holstein", new DateTime(2024, 06, 17), 1080, 120, 460, true, "Pastura"));

        }

        //Precarga de ovinos
        private void PreCargarOvinos()
        {
            AltaOvino(new Ovino("O0000001", "Macho", "Merino", new DateTime(2019, 03, 05), 300, 140, 70, false, 8));
            AltaOvino(new Ovino("O0000002", "Hembra", "Suffolk", new DateTime(2018, 08, 10), 250, 235, 65, true, 7));
            AltaOvino(new Ovino("O0000003", "Macho", "Corriedale", new DateTime(2017, 11, 17), 280, 195, 75, false, 9));
            AltaOvino(new Ovino("O0000004", "Hembra", "Dorset", new DateTime(2020, 05, 21), 320, 170, 68, true, 7));
            AltaOvino(new Ovino("O0000005", "Macho", "Rambouillet", new DateTime(2019, 09, 09), 295, 215, 72, false, 8));
            AltaOvino(new Ovino("O0000006", "Hembra", "Texel", new DateTime(2018, 02, 13), 310, 200, 70, true, 6));
            AltaOvino(new Ovino("O0000007", "Macho", "Shetland", new DateTime(2016, 07, 07), 300, 185, 74, false, 8));
            AltaOvino(new Ovino("O0000008", "Hembra", "Lincoln", new DateTime(2020, 01, 29), 285, 255, 66, true, 7));
            AltaOvino(new Ovino("O0000009", "Macho", "Cheviot", new DateTime(2021, 06, 15), 295, 165, 73, false, 9));
            AltaOvino(new Ovino("O0000010", "Hembra", "Finn", new DateTime(2019, 03, 18), 315, 225, 69, true, 8));
            AltaOvino(new Ovino("O0000011", "Hembra", "Merino", new DateTime(2020, 10, 14), 260, 145, 68, false, 8));
            AltaOvino(new Ovino("O0000012", "Macho", "Suffolk", new DateTime(2017, 04, 23), 270, 250, 73, true, 7));
            AltaOvino(new Ovino("O0000013", "Hembra", "Corriedale", new DateTime(2018, 12, 01), 290, 215, 66, false, 9));
            AltaOvino(new Ovino("O0000014", "Macho", "Dorset", new DateTime(2021, 06, 18), 305, 265, 64, true, 7));
            AltaOvino(new Ovino("O0000015", "Hembra", "Rambouillet", new DateTime(2019, 08, 07), 285, 195, 72, false, 8));
            AltaOvino(new Ovino("O0000016", "Macho", "Texel", new DateTime(2020, 02, 16), 295, 160, 69, true, 6));
            AltaOvino(new Ovino("O0000017", "Hembra", "Shetland", new DateTime(2016, 01, 25), 315, 240, 71, false, 8));
            AltaOvino(new Ovino("O0000018", "Macho", "Lincoln", new DateTime(2021, 07, 11), 275, 280, 67, true, 7));
            AltaOvino(new Ovino("O0000019", "Hembra", "Cheviot", new DateTime(2019, 09, 30), 320, 270, 70, false, 9));
            AltaOvino(new Ovino("O0000020", "Macho", "Finn", new DateTime(2017, 05, 20), 300, 150, 75, true, 8));
            AltaOvino(new Ovino("O0000021", "Hembra", "Merino", new DateTime(2021, 03, 03), 285, 205, 65, false, 8));
            AltaOvino(new Ovino("O0000022", "Macho", "Suffolk", new DateTime(2020, 11, 09), 265, 130, 70, true, 7));
            AltaOvino(new Ovino("O0000023", "Hembra", "Corriedale", new DateTime(2018, 07, 15), 290, 300, 72, false, 9));
            AltaOvino(new Ovino("O0000024", "Macho", "Dorset", new DateTime(2019, 12, 27), 310, 180, 68, true, 8));
            AltaOvino(new Ovino("O0000025", "Hembra", "Rambouillet", new DateTime(2021, 02, 19), 270, 270, 63, false, 8));
            AltaOvino(new Ovino("O0000026", "Macho", "Texel", new DateTime(2019, 05, 04), 290, 155, 74, true, 6));
            AltaOvino(new Ovino("O0000027", "Hembra", "Shetland", new DateTime(2017, 10, 21), 305, 220, 70, false, 9));
            AltaOvino(new Ovino("O0000028", "Macho", "Lincoln", new DateTime(2024, 06, 15), 280, 295, 66, true, 7));
            AltaOvino(new Ovino("O0000029", "Hembra", "Cheviot", new DateTime(2024, 06, 16), 315, 260, 71, false, 9));
            AltaOvino(new Ovino("O0000030", "Macho", "Finn", new DateTime(2024, 06, 17), 300, 125, 77, true, 8));

        }

        //Precarga de capatacez
        private void PreCargarCapataz()
        {
            AltaCapataz(new Capataz("capataz1@example.com", "StrongPass123", "Juan Pérez", new DateTime(2021, 05, 20), 6));
            AltaCapataz(new Capataz("capataz2@example.com", "Secure98765", "Ana Gómez", new DateTime(2020, 11, 15), 4));

        }

        //Precarga de peones
        private void PreCargarPeon()
        {
            AltaPeon(new Peon("peon1@example.com", "securePwd1", "Carlos Ruiz", new DateTime(2022, 04, 15), true));
            AltaPeon(new Peon("peon2@example.com", "securePwd2", "Ana López", new DateTime(2022, 03, 23), false));
            AltaPeon(new Peon("peon3@example.com", "securePwd3", "José Martínez", new DateTime(2022, 05, 09), true));
            AltaPeon(new Peon("peon4@example.com", "securePwd4", "Sofía Castro", new DateTime(2022, 06, 01), false));
            AltaPeon(new Peon("peon5@example.com", "securePwd5", "Marco Antonio", new DateTime(2022, 07, 18), true));
            AltaPeon(new Peon("peon6@example.com", "securePwd6", "Laura Jiménez", new DateTime(2022, 08, 24), false));
            AltaPeon(new Peon("peon7@example.com", "securePwd7", "Omar Vega", new DateTime(2022, 09, 30), true));
            AltaPeon(new Peon("peon8@example.com", "securePwd8", "Teresa Gómez", new DateTime(2022, 10, 15), false));
            AltaPeon(new Peon("peon9@example.com", "securePwd9", "Luis Fernández", new DateTime(2022, 11, 20), true));
            AltaPeon(new Peon("peon10@example.com", "securePwd10", "Diana Salazar", new DateTime(2022, 12, 05), false));

        }

        //Precarga de potreros
        private void PreCargarPotreros()
        {
            AltaPotrero(new Potrero("Potrero Norte", 120.5, 50));
            AltaPotrero(new Potrero("Potrero Sur", 150.0, 60));
            AltaPotrero(new Potrero("Potrero Este", 98.3, 40));
            AltaPotrero(new Potrero("Potrero Oeste", 110.0, 50));
            AltaPotrero(new Potrero("Potrero Central", 200.0, 100));
            AltaPotrero(new Potrero("Potrero Alto", 75.2, 30));
            AltaPotrero(new Potrero("Potrero Bajo", 85.7, 45));
            AltaPotrero(new Potrero("Potrero Viejo", 60.0, 25));
            AltaPotrero(new Potrero("Potrero Nuevo", 130.4, 65));
            AltaPotrero(new Potrero("Potrero de la Colina", 200, 50));
        }

        //Precarga de tareas
        private void PreCargarTareas()
        {
            AltaTarea("peon1@example.com", new Tarea("Mantenimiento preventivo de vehículos de la estancia", new DateTime(2021, 8, 3), true, new DateTime(2023, 8, 4), "Vehículos listos para operar"));
            AltaTarea("peon1@example.com", new Tarea("Reparación de sistema de alimentación automática", new DateTime(2023, 8, 5), true, new DateTime(2023, 8, 6), "Sistema restaurado a pleno funcionamiento"));
            AltaTarea("peon1@example.com", new Tarea("Verificación de depósitos de agua", new DateTime(2023, 8, 7), false, DateTime.MinValue, "Pendiente de revisión próxima semana"));
            AltaTarea("peon1@example.com", new Tarea("Capacitación en manejo de nuevas tecnologías agrícolas", new DateTime(2023, 8, 9), false, DateTime.MinValue, "Capacitación programada para el próximo mes"));
            AltaTarea("peon1@example.com", new Tarea("Recolección de muestras de suelo", new DateTime(2023, 8, 11), true, new DateTime(2023, 8, 12), "Muestras enviadas al laboratorio"));
            AltaTarea("peon1@example.com", new Tarea("Revisión de cercas en el sector este", new DateTime(2023, 8, 13), true, new DateTime(2023, 8, 14), "Reparaciones menores realizadas"));
            AltaTarea("peon1@example.com", new Tarea("Inspección de sistemas de seguridad", new DateTime(2023, 8, 15), true, new DateTime(2023, 8, 16), "Todos los sistemas funcionan correctamente"));
            AltaTarea("peon1@example.com", new Tarea("Actualización de planillas de registro de ganado", new DateTime(2023, 8, 17), false, DateTime.MinValue, "Actualización pendiente"));
            AltaTarea("peon1@example.com", new Tarea("Preparativos para la feria ganadera local", new DateTime(2023, 8, 19), true, new DateTime(2023, 8, 20), "Preparativos completados, todo listo para la feria"));
            AltaTarea("peon1@example.com", new Tarea("Vacunación contra la fiebre aftosa", new DateTime(2023, 8, 21), true, new DateTime(2023, 8, 22), "Vacunación completa sin contratiempos"));
            AltaTarea("peon1@example.com", new Tarea("Control de crecimiento de corderos", new DateTime(2023, 8, 23), true, new DateTime(2023, 8, 24), "Crecimiento dentro de los parámetros normales"));
            AltaTarea("peon1@example.com", new Tarea("Organización de la logística para transporte de lana", new DateTime(2023, 8, 25), true, new DateTime(2023, 8, 26), "Logística confirmada y en marcha"));
            AltaTarea("peon1@example.com", new Tarea("Mantenimiento de bombas de agua", new DateTime(2023, 8, 27), false, DateTime.MinValue, "Revisión programada para el próximo trimestre"));
            AltaTarea("peon1@example.com", new Tarea("Revisión de alimentadores en el sector de engorde", new DateTime(2023, 8, 29), false, DateTime.MinValue, "Revisión programada para la próxima semana"));
            AltaTarea("peon1@example.com", new Tarea("Revisión de alimentadores en el sector de engorde", new DateTime(2021, 8, 29), false, DateTime.MinValue, "Revisión programada para el próximo día"));
            AltaTarea("peon2@example.com", new Tarea("Chequeo de salud del ganado bovino de leche", new DateTime(2023, 8, 31), true, new DateTime(2023, 9, 1), "Sin problemas de salud reportados"));
            AltaTarea("peon2@example.com", new Tarea("Recuento anual de cabezas de ganado", new DateTime(2023, 9, 2), false, DateTime.MinValue, "Recuento pendiente para fin de año"));
            AltaTarea("peon2@example.com", new Tarea("Corte de maleza en cercas perimetrales", new DateTime(2023, 9, 4), false, DateTime.MinValue, "Pendiente de asignación de recursos"));
            AltaTarea("peon2@example.com", new Tarea("Revisión de sistemas de ordeño automático", new DateTime(2023, 9, 6), true, new DateTime(2023, 9, 7), "Sistemas operativos y eficientes"));
            AltaTarea("peon2@example.com", new Tarea("Capacitación sobre bienestar animal", new DateTime(2023, 9, 8), true, new DateTime(2023, 9, 9), "Capacitación completada con éxito"));
            AltaTarea("peon2@example.com", new Tarea("Preparación de dietas estacionales para ovinos", new DateTime(2023, 9, 10), false, DateTime.MinValue, "Pendiente de aprobación del veterinario"));
            AltaTarea("peon2@example.com", new Tarea("Limpieza de caminos internos", new DateTime(2023, 9, 12), true, new DateTime(2023, 9, 13), "Caminos despejados y mantenidos"));
            AltaTarea("peon2@example.com", new Tarea("Supervisión de obras de ampliación de corrales", new DateTime(2023, 9, 14), false, DateTime.MinValue, "En espera de aprobación final del proyecto"));
            AltaTarea("peon2@example.com", new Tarea("Revisión de protocolos de emergencia", new DateTime(2023, 9, 16), false, DateTime.MinValue, "Revisión programada para el próximo mes"));
            AltaTarea("peon2@example.com", new Tarea("Capacitación en manejo de equipos de esquila", new DateTime(2023, 9, 18), false, DateTime.MinValue, "Capacitación reprogramada para el siguiente cuarto"));
            AltaTarea("peon2@example.com", new Tarea("Control de calidad del agua de bebida", new DateTime(2023, 9, 20), true, new DateTime(2023, 9, 21), "Agua dentro de los estándares de calidad"));
            AltaTarea("peon2@example.com", new Tarea("Planificación de rotación de pasturas", new DateTime(2023, 9, 22), true, new DateTime(2023, 9, 23), "Planificación completada para el próximo año"));
            AltaTarea("peon2@example.com", new Tarea("Organización de jornada de puertas abiertas", new DateTime(2023, 9, 24), false, DateTime.MinValue, "Pendiente de confirmación de fechas"));
            AltaTarea("peon2@example.com", new Tarea("Reparación de equipos de refrigeración de leche", new DateTime(2023, 9, 26), true, new DateTime(2023, 9, 27), "Reparación completada con éxito"));
            AltaTarea("peon2@example.com", new Tarea("Manejo de residuos y sostenibilidad", new DateTime(2023, 9, 28), false, DateTime.MinValue, "En proceso de evaluación de proveedores"));
            AltaTarea("peon3@example.com", new Tarea("Mantenimiento preventivo de vehículos de la estancia", new DateTime(2023, 8, 3), true, new DateTime(2023, 8, 4), "Mantenimiento completado, todos los vehículos operativos."));
            AltaTarea("peon3@example.com", new Tarea("Reparación de sistema de alimentación automática", new DateTime(2023, 8, 5), true, new DateTime(2023, 8, 6), "Sistema reparado y funcionando correctamente."));
            AltaTarea("peon3@example.com", new Tarea("Verificación de depósitos de agua", new DateTime(2023, 8, 7), false, DateTime.MinValue, "Pendiente de inspección."));
            AltaTarea("peon3@example.com", new Tarea("Capacitación en manejo de nuevas tecnologías agrícolas", new DateTime(2023, 8, 9), false, DateTime.MinValue, "Capacitación programada para el próximo mes."));
            AltaTarea("peon3@example.com", new Tarea("Recolección de muestras de suelo", new DateTime(2023, 8, 11), true, new DateTime(2023, 8, 12), "Muestras enviadas al laboratorio."));
            AltaTarea("peon3@example.com", new Tarea("Revisión de cercas en el sector este", new DateTime(2023, 8, 13), true, new DateTime(2023, 8, 14), "Cercas revisadas y reparadas donde fue necesario."));
            AltaTarea("peon3@example.com", new Tarea("Inspección de sistemas de seguridad", new DateTime(2023, 8, 15), true, new DateTime(2023, 8, 16), "Sistemas verificados sin incidencias."));
            AltaTarea("peon3@example.com", new Tarea("Evaluación bimestral de la salud general del ganado enfermo", new DateTime(2024, 3, 28), true, new DateTime(2024, 3, 29), "Evaluación completada, ganado mejorando."));
            AltaTarea("peon3@example.com", new Tarea("Actualización de planillas de registro de ganado", new DateTime(2023, 8, 17), false, DateTime.MinValue, "Actualización pendiente para el próximo ciclo de revisión."));
            AltaTarea("peon3@example.com", new Tarea("Preparativos para la feria ganadera local", new DateTime(2023, 8, 19), true, new DateTime(2023, 8, 20), "Todos los preparativos completados."));
            AltaTarea("peon3@example.com", new Tarea("Vacunación contra la fiebre aftosa", new DateTime(2023, 8, 21), true, new DateTime(2023, 8, 22), "Vacunación completada sin problemas."));
            AltaTarea("peon3@example.com", new Tarea("Control de crecimiento de corderos", new DateTime(2023, 8, 23), true, new DateTime(2023, 8, 24), "Crecimiento dentro de los parámetros esperados."));
            AltaTarea("peon3@example.com", new Tarea("Organización de la logística para transporte de lana", new DateTime(2023, 8, 25), true, new DateTime(2023, 8, 26), "Logística organizada y en proceso."));
            AltaTarea("peon3@example.com", new Tarea("Mantenimiento de bombas de agua", new DateTime(2023, 8, 27), false, DateTime.MinValue, "Mantenimiento programado para el próximo trimestre."));
            AltaTarea("peon3@example.com", new Tarea("Revisión de alimentadores en el sector de engorde", new DateTime(2023, 8, 29), false, DateTime.MinValue, "Revisión programada para la próxima semana."));
            AltaTarea("peon4@example.com", new Tarea("Chequeo de salud del ganado bovino de leche", new DateTime(2023, 8, 31), true, new DateTime(2023, 9, 1), "Ganado en excelente estado de salud."));
            AltaTarea("peon4@example.com", new Tarea("Recuento anual de cabezas de ganado", new DateTime(2023, 9, 2), false, DateTime.MinValue, "Recuento programado para finales de año."));
            AltaTarea("peon4@example.com", new Tarea("Corte de maleza en cercas perimetrales", new DateTime(2023, 9, 4), true, new DateTime(2023, 9, 5), "Maleza cortada y retirada."));
            AltaTarea("peon4@example.com", new Tarea("Revisión de sistemas de ordeño automático", new DateTime(2023, 9, 6), true, new DateTime(2023, 9, 7), "Sistemas revisados y funcionando correctamente."));
            AltaTarea("peon4@example.com", new Tarea("Capacitación sobre bienestar animal", new DateTime(2023, 9, 8), false, DateTime.MinValue, "Capacitación programada para el próximo mes."));
            AltaTarea("peon4@example.com", new Tarea("Preparación de dietas estacionales para ovinos", new DateTime(2023, 9, 10), false, DateTime.MinValue, "Dietas en revisión por nutricionista."));
            AltaTarea("peon4@example.com", new Tarea("Limpieza de caminos internos", new DateTime(2023, 9, 12), true, new DateTime(2023, 9, 13), "Caminos limpios y accesibles."));
            AltaTarea("peon4@example.com", new Tarea("Supervisión de obras de ampliación de corrales", new DateTime(2023, 9, 14), true, new DateTime(2023, 9, 15), "Supervisión completada, obra en progreso."));
            AltaTarea("peon4@example.com", new Tarea("Revisión de protocolos de emergencia", new DateTime(2023, 9, 16), true, new DateTime(2023, 9, 17), "Protocolos actualizados y comunicados a todo el personal."));
            AltaTarea("peon4@example.com", new Tarea("Capacitación en manejo de equipos de esquila", new DateTime(2023, 9, 18), true, new DateTime(2023, 9, 19), "Capacitación realizada con éxito."));
            AltaTarea("peon4@example.com", new Tarea("Control de calidad del agua de bebida", new DateTime(2023, 9, 20), true, new DateTime(2023, 9, 21), "Agua analizada y apta para consumo."));
            AltaTarea("peon4@example.com", new Tarea("Planificación de rotación de pasturas", new DateTime(2023, 9, 22), true, new DateTime(2023, 9, 23), "Planificación completada y ejecutada."));
            AltaTarea("peon4@example.com", new Tarea("Organización de jornada de puertas abiertas", new DateTime(2023, 9, 24), false, DateTime.MinValue, "Evento realizado sin problemas."));
            AltaTarea("peon4@example.com", new Tarea("Instalación de nuevas bombas de agua", new DateTime(2023, 10, 1), true, new DateTime(2023, 10, 2), "Instalación completada satisfactoriamente."));
            AltaTarea("peon4@example.com", new Tarea("Reparación de vallas en el sector oeste", new DateTime(2023, 10, 3), true, new DateTime(2023, 10, 4), "Reparaciones finalizadas, vallas seguras."));
            AltaTarea("peon5@example.com", new Tarea("Inspección de instalaciones eléctricas", new DateTime(2023, 10, 5), false, DateTime.MinValue, "Pendiente de inspección."));
            AltaTarea("peon5@example.com", new Tarea("Implementación de sistema de rastreo para ovinos", new DateTime(2023, 10, 7), true, new DateTime(2023, 10, 8), "Sistema operativo y en funcionamiento."));
            AltaTarea("peon5@example.com", new Tarea("Organización de la cosecha de forraje", new DateTime(2023, 10, 9), false, DateTime.MinValue, "Planificación en curso."));
            AltaTarea("peon5@example.com", new Tarea("Manejo y tratamiento de lana", new DateTime(2023, 10, 11), true, new DateTime(2023, 10, 12), "Tratamiento completado, lana lista para mercado."));
            AltaTarea("peon5@example.com", new Tarea("Supervisión de la dosificación de suplementos", new DateTime(2023, 10, 13), false, DateTime.MinValue, "Supervisión programada para la próxima semana."));
            AltaTarea("peon5@example.com", new Tarea("Control de registros de producción lechera", new DateTime(2023, 10, 15), true, new DateTime(2023, 10, 16), "Datos actualizados y almacenados correctamente."));
            AltaTarea("peon5@example.com", new Tarea("Mantenimiento de caminos rurales internos", new DateTime(2023, 10, 17), true, new DateTime(2023, 10, 18), "Mantenimiento completado, caminos accesibles."));
            AltaTarea("peon5@example.com", new Tarea("Programación de esquila pre-venta", new DateTime(2023, 10, 19), false, DateTime.MinValue, "A la espera de confirmación de fechas."));
            AltaTarea("peon5@example.com", new Tarea("Monitoreo de salud animal post-vacunación", new DateTime(2023, 10, 21), false, DateTime.MinValue, "Monitoreo pendiente tras vacunación."));
            AltaTarea("peon5@example.com", new Tarea("Revisión de equipos de ordeño", new DateTime(2023, 10, 23), true, new DateTime(2023, 10, 24), "Equipos en perfecto estado."));
            AltaTarea("peon5@example.com", new Tarea("Capacitación sobre gestión de pasturas", new DateTime(2023, 10, 25), false, DateTime.MinValue, "Capacitación programada para el próximo mes."));
            AltaTarea("peon5@example.com", new Tarea("Organización de datos de cría selectiva", new DateTime(2023, 10, 27), true, new DateTime(2023, 10, 28), "Datos organizados y listos para análisis."));
            AltaTarea("peon5@example.com", new Tarea("Revisión anual de maquinaria agrícola", new DateTime(2023, 10, 29), true, new DateTime(2023, 10, 30), "Revisión completada, todo operativo."));
            AltaTarea("peon5@example.com", new Tarea("Coordinación de transporte de animales a mercado", new DateTime(2023, 10, 31), false, DateTime.MinValue, "Coordinación en proceso."));
            AltaTarea("peon5@example.com", new Tarea("Verificación de sistemas de almacenamiento de grano", new DateTime(2023, 11, 2), true, new DateTime(2023, 11, 3), "Sistemas verificados, todo en orden."));
            AltaTarea("peon6@example.com", new Tarea("Limpieza y desinfección de áreas de alojamiento animal", new DateTime(2023, 12, 5), true, new DateTime(2023, 12, 6), "Limpieza y desinfección completadas."));
            AltaTarea("peon6@example.com", new Tarea("Mantenimiento de vías de acceso principales", new DateTime(2023, 12, 7), true, new DateTime(2023, 12, 8), "Mantenimiento realizado, accesos en perfecto estado."));
            AltaTarea("peon6@example.com", new Tarea("Control de roedores en almacenamiento de granos", new DateTime(2023, 12, 9), true, new DateTime(2023, 12, 10), "Control efectivo, no se detectaron roedores."));
            AltaTarea("peon6@example.com", new Tarea("Revisión de cercados eléctricos", new DateTime(2023, 12, 11), false, DateTime.MinValue, "Pendiente de revisión por personal especializado."));
            AltaTarea("peon6@example.com", new Tarea("Implementación de medidas de ahorro de agua", new DateTime(2023, 12, 13), false, DateTime.MinValue, "Medidas en proceso de aprobación."));
            AltaTarea("peon6@example.com", new Tarea("Evaluación de la condición corporal del ganado", new DateTime(2023, 12, 15), true, new DateTime(2023, 12, 16), "Evaluación completada, ganado en buenas condiciones."));
            AltaTarea("peon6@example.com", new Tarea("Preparación de dietas invernales", new DateTime(2023, 12, 17), false, DateTime.MinValue, "Preparación pendiente de revisión nutricional."));
            AltaTarea("peon6@example.com", new Tarea("Revisión y reparación de maquinaria de esquila", new DateTime(2023, 12, 19), true, new DateTime(2023, 12, 20), "Maquinaria revisada y todas las reparaciones necesarias realizadas."));
            AltaTarea("peon6@example.com", new Tarea("Organización del almacenamiento de forraje", new DateTime(2023, 12, 21), false, DateTime.MinValue, "Organización programada para el final de la temporada."));
            AltaTarea("peon6@example.com", new Tarea("Planificación de vacunaciones  para el próximo año", new DateTime(2023, 12, 23), true, new DateTime(2023, 12, 24), "Planificación completada y lista para implementar."));
            AltaTarea("peon6@example.com", new Tarea("Inventario de fin de año de todos los insumos", new DateTime(2023, 12, 25), true, new DateTime(2023, 12, 26), "Inventario completado, todo contabilizado."));
            AltaTarea("peon6@example.com", new Tarea("Instalación de cámaras de seguridad en establos", new DateTime(2023, 12, 27), false, DateTime.MinValue, "Instalación programada para el próximo trimestre."));
            AltaTarea("peon6@example.com", new Tarea("Capacitación sobre manejo de estrés en animales", new DateTime(2023, 12, 29), false, DateTime.MinValue, "Capacitación aún no agendada."));
            AltaTarea("peon6@example.com", new Tarea("Auditoría interna de procedimientos operativos", new DateTime(2024, 1, 2), true, new DateTime(2024, 1, 3), "Auditoría realizada, procedimientos conformes."));
            AltaTarea("peon6@example.com", new Tarea("Mejora de instalaciones para manejo durante esquila", new DateTime(2024, 1, 4), false, DateTime.MinValue, "Mejoras en fase de diseño."));
            AltaTarea("peon7@example.com", new Tarea("Planificación de estrategias de marketing de carne", new DateTime(2024, 1, 8), false, DateTime.MinValue, "Estrategias en desarrollo, pendiente de revisión final."));
            AltaTarea("peon7@example.com", new Tarea("Revisión de sistemas de alimentación mecánica", new DateTime(2024, 1, 10), true, new DateTime(2024, 1, 11), "Revisión completada, sistemas operativos."));
            AltaTarea("peon7@example.com", new Tarea("Control de calidad de la producción lechera", new DateTime(2024, 1, 12), false, DateTime.MinValue, "Control programado para el próximo mes."));
            AltaTarea("peon7@example.com", new Tarea("Supervisión de la construcción de un nuevo invernadero", new DateTime(2024, 1, 14), true, new DateTime(2024, 1, 15), "Supervisión efectiva, construcción en curso."));
            AltaTarea("peon7@example.com", new Tarea("Implementación de nuevas tecnologías de riego", new DateTime(2024, 1, 16), false, DateTime.MinValue, "Implementación a la espera de presupuesto."));
            AltaTarea("peon7@example.com", new Tarea("Gestión de residuos y sostenibilidad ambiental", new DateTime(2024, 1, 18), true, new DateTime(2024, 1, 19), "Gestión implementada, seguimiento en proceso."));
            AltaTarea("peon7@example.com", new Tarea("Capacitación en primeros auxilios para el personal", new DateTime(2024, 1, 20), false, DateTime.MinValue, "Capacitación pendiente de programar."));
            AltaTarea("peon7@example.com", new Tarea("Actualización de software de gestión de la granja", new DateTime(2024, 1, 22), true, new DateTime(2024, 1, 23), "Software actualizado a la última versión disponible."));
            AltaTarea("peon7@example.com", new Tarea("Revisión de la flota de vehículos de la granja", new DateTime(2024, 1, 24), false, DateTime.MinValue, "Revisión programada para el final del trimestre."));
            AltaTarea("peon7@example.com", new Tarea("Planificación de la rotación de cultivos forrajeros", new DateTime(2024, 1, 26), true, new DateTime(2024, 1, 27), "Planificación completada, listo para implementar."));
            AltaTarea("peon7@example.com", new Tarea("Desarrollo de un plan de emergencia actualizado", new DateTime(2024, 1, 28), false, DateTime.MinValue, "Desarrollo en curso, pendiente de aprobación."));
            AltaTarea("peon7@example.com", new Tarea("Organización de una capacitación sobre nutrición animal", new DateTime(2024, 1, 30), true, new DateTime(2024, 1, 31), "Capacitación organizada y programada."));
            AltaTarea("peon7@example.com", new Tarea("Preparación de áreas para partos de primavera", new DateTime(2024, 2, 1), true, new DateTime(2024, 2, 2), "Áreas preparadas exitosamente para los partos."));
            AltaTarea("peon7@example.com", new Tarea("Revisión y mantenimiento de los equipos de esquila", new DateTime(2024, 2, 3), true, new DateTime(2024, 2, 4), "Mantenimiento completo, equipos listos para la temporada."));
            AltaTarea("peon7@example.com", new Tarea("Capacitación en técnicas de cultivo", new DateTime(2024, 4, 15), true, new DateTime(2024, 4, 16), "Capacitación realizada, todo en orden."));
            AltaTarea("peon8@example.com", new Tarea("Capacitación en técnicas modernas de pastoreo", new DateTime(2024, 2, 5), true, new DateTime(2024, 2, 6), "Capacitación realizada, personal actualizado."));
            AltaTarea("peon8@example.com", new Tarea("Actualización de los sistemas de seguimiento de ganado", new DateTime(2024, 2, 7), true, new DateTime(2024, 2, 8), "Sistemas actualizados y funcionando correctamente."));
            AltaTarea("peon8@example.com", new Tarea("Inspección de las infraestructuras de contención", new DateTime(2024, 2, 9), true, new DateTime(2024, 2, 10), "Inspección completa, infraestructuras en buen estado."));
            AltaTarea("peon8@example.com", new Tarea("Implementación de un nuevo programa de alimentación", new DateTime(2024, 2, 11), false, DateTime.MinValue, "Programa en desarrollo, pendiente de implementación."));
            AltaTarea("peon8@example.com", new Tarea("Mantenimiento de las bombas de agua del sector sur", new DateTime(2024, 2, 13), false, DateTime.MinValue, "Mantenimiento programado para el próximo mes."));
            AltaTarea("peon8@example.com", new Tarea("Organización del archivo de registros sanitarios", new DateTime(2024, 2, 15), false, DateTime.MinValue, "Organización pendiente tras auditoría interna."));
            AltaTarea("peon8@example.com", new Tarea("Revisión de la calidad del forraje almacenado", new DateTime(2024, 2, 17), false, DateTime.MinValue, "Revisión programada para la próxima semana."));
            AltaTarea("peon8@example.com", new Tarea("Planificación de la rotación de pasturas para el año", new DateTime(2024, 2, 19), false, DateTime.MinValue, "Planificación en curso, pendiente de finalización."));
            AltaTarea("peon8@example.com", new Tarea("Verificación de cercados en áreas de pastoreo", new DateTime(2024, 2, 21), true, new DateTime(2024, 2, 22), "Verificación completada, todos los cercados seguros."));
            AltaTarea("peon8@example.com", new Tarea("Reparación de la maquinaria de labranza", new DateTime(2024, 2, 23), true, new DateTime(2024, 2, 24), "Reparación efectuada, maquinaria operativa."));
            AltaTarea("peon8@example.com", new Tarea("Control y prevención de enfermedades en otoño", new DateTime(2024, 2, 25), true, new DateTime(2024, 2, 26), "Control efectuado, no se detectaron enfermedades."));
            AltaTarea("peon8@example.com", new Tarea("Capacitación sobre bienestar animal durante el transporte", new DateTime(2024, 2, 27), true, new DateTime(2024, 2, 28), "Capacitación completada, personal instruido."));
            AltaTarea("peon8@example.com", new Tarea("Monitoreo y ajuste de los sistemas de riego", new DateTime(2024, 2, 29), true, new DateTime(2024, 3, 1), "Ajustes realizados, sistemas optimizados."));
            AltaTarea("peon8@example.com", new Tarea("Preparativos para la feria de ganado local", new DateTime(2024, 3, 2), false, DateTime.MinValue, "Preparativos en fase inicial."));
            AltaTarea("peon8@example.com", new Tarea("Inspección anual de instalaciones eléctricas", new DateTime(2024, 3, 4), true, new DateTime(2024, 3, 5), "Inspección realizada, todo conforme a normativa."));
            AltaTarea("peon9@example.com", new Tarea("Evaluación de la eficiencia del consumo de energía", new DateTime(2024, 3, 6), false, DateTime.MinValue, "Evaluación pendiente de realización."));
            AltaTarea("peon9@example.com", new Tarea("Revisión del estado de las instalaciones de ordeño", new DateTime(2024, 3, 8), true, new DateTime(2024, 3, 9), "Instalaciones revisadas, en excelente estado."));
            AltaTarea("peon9@example.com", new Tarea("Ajuste de dietas según evaluaciones nutricionales recientes", new DateTime(2024, 3, 10), false, DateTime.MinValue, "Ajuste de dietas a la espera de nuevos datos nutricionales."));
            AltaTarea("peon9@example.com", new Tarea("Revisión de protocolos de manejo en situaciones de emergencia", new DateTime(2024, 3, 12), false, DateTime.MinValue, "Revisión programada para el próximo trimestre."));
            AltaTarea("peon9@example.com", new Tarea("Implementación de medidas contra parásitos externos", new DateTime(2024, 3, 14), true, new DateTime(2024, 3, 15), "Medidas implementadas, monitoreo continuo."));
            AltaTarea("peon9@example.com", new Tarea("Mantenimiento de senderos y caminos internos", new DateTime(2024, 3, 16), true, new DateTime(2024, 3, 17), "Mantenimiento completado, todos los caminos accesibles."));
            AltaTarea("peon9@example.com", new Tarea("Supervisión de las prácticas de manejo sostenible", new DateTime(2024, 3, 18), true, new DateTime(2024, 3, 19), "Supervisión realizada, prácticas adecuadas en uso."));
            AltaTarea("peon9@example.com", new Tarea("Organización de cursos de formación para nuevos empleados", new DateTime(2024, 3, 20), true, new DateTime(2024, 3, 21), "Cursos organizados y calendarizados."));
            AltaTarea("peon9@example.com", new Tarea("Evaluación y mejora de las estrategias de marketing de productos lácteos", new DateTime(2024, 3, 22), false, DateTime.MinValue, "Evaluación en curso, pendiente de resultados finales."));
            AltaTarea("peon9@example.com", new Tarea("Revisión y actualización del plan de vacunación", new DateTime(2024, 3, 24), true, new DateTime(2024, 3, 25), "Plan de vacunación actualizado."));
            AltaTarea("peon9@example.com", new Tarea("Planificación de mejoras en el sistema de gestión de residuos", new DateTime(2024, 3, 26), false, DateTime.MinValue, "Planificación pendiente de revisión ambiental."));
            AltaTarea("peon9@example.com", new Tarea("Evaluación trimestral de la salud general del ganado", new DateTime(2024, 3, 28), true, new DateTime(2024, 3, 29), "Evaluación completada, ganado saludable."));
            AltaTarea("peon9@example.com", new Tarea("Preparación de la documentación para auditorías externas", new DateTime(2024, 3, 30), true, new DateTime(2024, 3, 31), "Documentación preparada y lista para auditorías."));
            AltaTarea("peon9@example.com", new Tarea("Revisión de sistemas de ventilación en los establos", new DateTime(2024, 4, 1), true, new DateTime(2024, 4, 2), "Sistemas revisados y funcionando correctamente."));
            AltaTarea("peon9@example.com", new Tarea("Capacitación en técnicas avanzadas de fertilización", new DateTime(2024, 4, 3), true, new DateTime(2024, 4, 4), "Capacitación completada con éxito."));
            AltaTarea("peon10@example.com", new Tarea("Implementación de sistemas de monitoreo climático", new DateTime(2024, 4, 5), false, DateTime.MinValue, "Implementación pendiente de entrega de equipos."));
            AltaTarea("peon10@example.com", new Tarea("Control de maleza en pastizales", new DateTime(2024, 4, 7), true, new DateTime(2024, 4, 8), "Control efectivo realizado."));
            AltaTarea("peon10@example.com", new Tarea("Inspección de tanques de almacenamiento de leche", new DateTime(2024, 4, 9), true, new DateTime(2024, 4, 10), "Tanques inspeccionados, en buen estado."));
            AltaTarea("peon10@example.com", new Tarea("Revisión de la red de distribución de agua", new DateTime(2024, 4, 11), false, DateTime.MinValue, "Revisión programada para el próximo trimestre."));
            AltaTarea("peon10@example.com", new Tarea("Planificación de la exposición anual de ganado", new DateTime(2024, 4, 13), true, new DateTime(2024, 4, 14), "Exposición planificada y organizada."));
            AltaTarea("peon10@example.com", new Tarea("Mantenimiento preventivo de tractores y maquinaria pesada", new DateTime(2024, 4, 15), true, new DateTime(2024, 4, 16), "Mantenimiento realizado, todo en orden."));
            AltaTarea("peon10@example.com", new Tarea("Auditoría de recursos humanos para el segundo trimestre", new DateTime(2024, 4, 17), false, DateTime.MinValue, "Auditoría pendiente de inicio."));
            AltaTarea("peon10@example.com", new Tarea("Monitoreo de condiciones de salud en las áreas de cría", new DateTime(2024, 4, 19), true, new DateTime(2024, 4, 20), "Monitoreo realizado, sin problemas detectados."));
            AltaTarea("peon10@example.com", new Tarea("Capacitación sobre manejo y cuidado de equipos agrícolas", new DateTime(2024, 4, 21), false, DateTime.MinValue, "Capacitación a ser agendada."));
            AltaTarea("peon10@example.com", new Tarea("Implementación de un nuevo sistema de gestión de datos", new DateTime(2024, 4, 23), true, new DateTime(2024, 4, 24), "Sistema implementado y en funcionamiento."));
            AltaTarea("peon10@example.com", new Tarea("Revisión de protocolos sanitarios para enfermedades transmisibles", new DateTime(2024, 4, 25), false, DateTime.MinValue, "Revisión programada para la próxima reunión de personal."));
            AltaTarea("peon10@example.com", new Tarea("Actualización de políticas de seguridad en el trabajo", new DateTime(2024, 4, 27), true, new DateTime(2024, 4, 28), "Políticas actualizadas y comunicadas a todos los empleados."));
            AltaTarea("peon10@example.com", new Tarea("Revisión anual de los sistemas de alarmas de incendio", new DateTime(2024, 4, 29), true, new DateTime(2024, 4, 30), "Sistemas revisados y totalmente operativos."));
            AltaTarea("peon10@example.com", new Tarea("Capacitación en bienestar animal y técnicas de manejo", new DateTime(2024, 5, 1), false, DateTime.MinValue, "Capacitación pendiente de confirmar fechas."));
            AltaTarea("peon10@example.com", new Tarea("Evaluación de impacto ambiental de nuevas construcciones", new DateTime(2024, 5, 3), true, new DateTime(2024, 5, 4), "Evaluación completada, impacto dentro de normativas."));

        }
        //Precarga de registros de vacunación
        private void PreCargarRegistroVacunacion()
        {
            List<RegistroVacunacion> Registros = new List<RegistroVacunacion>();
            Registros.Add(new RegistroVacunacion("B0000001", new Vacuna("Vacuna contra la leptospirosis", "Previene la leptospirosis, que puede causar insuficiencia renal", "Bacteria Leptospira"), new DateTime(2023, 1, 15)));
            Registros.Add(new RegistroVacunacion("B0000002", new Vacuna("Vacuna contra la brucelosis", "Control de la brucelosis, que puede causar abortos en los animales", "Bacteria Brucella"), new DateTime(2023, 2, 20)));
            Registros.Add(new RegistroVacunacion("B0000003", new Vacuna("Vacuna contra la clostridiosis", "Protege contra infecciones por Clostridium, que pueden ser fatales", "Bacteria Clostridium"), new DateTime(2023, 3, 10)));
            Registros.Add(new RegistroVacunacion("B0000004", new Vacuna("Vacuna IBR", "Protege contra la Rinotraqueitis Infecciosa Bovina", "Virus BHV-1"), new DateTime(2023, 4, 5)));
            Registros.Add(new RegistroVacunacion("B0000005", new Vacuna("Vacuna antirrábica", "Protege contra la rabia en todos los animales", "Virus de la rabia"), new DateTime(2023, 5, 25)));
            Registros.Add(new RegistroVacunacion("B0000006", new Vacuna("Vacuna contra la diarrea viral bovina", "Prevención de la diarrea viral bovina, que afecta a los bovinos de todas las edades", "Virus de la diarrea viral bovina"), new DateTime(2023, 6, 15)));
            Registros.Add(new RegistroVacunacion("B0000007", new Vacuna("Vacuna contra la fiebre aftosa", "Prevención de fiebre aftosa, una enfermedad viral altamente contagiosa", "Virus de la fiebre aftosa"), new DateTime(2023, 7, 20)));
            Registros.Add(new RegistroVacunacion("B0000008", new Vacuna("Vacuna contra el carbunco bacteridiano", "Protege contra el carbunco bacteridiano, una enfermedad mortal", "Bacillus anthracis"), new DateTime(2023, 8, 10)));
            Registros.Add(new RegistroVacunacion("B0000009", new Vacuna("Vacuna contra la peste bovina", "Prevención de la peste bovina, una enfermedad viral erradicada pero con vacunación preventiva en áreas de riesgo", "Virus de la peste bovina"), new DateTime(2023, 9, 5)));
            Registros.Add(new RegistroVacunacion("B0000010", new Vacuna("Vacuna contra la paratuberculosis", "Control de la paratuberculosis o enfermedad de Johne, que afecta principalmente a los rumiantes", "Mycobacterium avium subsp. paratuberculosis"), new DateTime(2023, 10, 25)));
            Registros.Add(new RegistroVacunacion("B0000011", new Vacuna("Vacuna contra la leptospirosis", "Previene la leptospirosis, que puede causar insuficiencia renal", "Bacteria Leptospira"), new DateTime(2023, 11, 15)));
            Registros.Add(new RegistroVacunacion("B0000012", new Vacuna("Vacuna contra la brucelosis", "Control de la brucelosis, que puede causar abortos en los animales", "Bacteria Brucella"), new DateTime(2023, 12, 20)));
            Registros.Add(new RegistroVacunacion("B0000013", new Vacuna("Vacuna contra la clostridiosis", "Protege contra infecciones por Clostridium, que pueden ser fatales", "Bacteria Clostridium"), new DateTime(2024, 1, 10)));
            Registros.Add(new RegistroVacunacion("B0000014", new Vacuna("Vacuna IBR", "Protege contra la Rinotraqueitis Infecciosa Bovina", "Virus BHV-1"), new DateTime(2024, 2, 5)));
            Registros.Add(new RegistroVacunacion("B0000015", new Vacuna("Vacuna antirrábica", "Protege contra la rabia en todos los animales", "Virus de la rabia"), new DateTime(2024, 3, 25)));
            Registros.Add(new RegistroVacunacion("B0000016", new Vacuna("Vacuna contra la diarrea viral bovina", "Prevención de la diarrea viral bovina, que afecta a los bovinos de todas las edades", "Virus de la diarrea viral bovina"), new DateTime(2024, 4, 15)));
            Registros.Add(new RegistroVacunacion("B0000017", new Vacuna("Vacuna contra la fiebre aftosa", "Prevención de fiebre aftosa, una enfermedad viral altamente contagiosa", "Virus de la fiebre aftosa"), new DateTime(2024, 5, 20)));
            Registros.Add(new RegistroVacunacion("B0000018", new Vacuna("Vacuna contra el carbunco bacteridiano", "Protege contra el carbunco bacteridiano, una enfermedad mortal", "Bacillus anthracis"), new DateTime(2024, 6, 10)));
            Registros.Add(new RegistroVacunacion("B0000019", new Vacuna("Vacuna contra la peste bovina", "Prevención de la peste bovina, una enfermedad viral erradicada pero con vacunación preventiva en áreas de riesgo", "Virus de la peste bovina"), new DateTime(2024, 7, 5)));
            Registros.Add(new RegistroVacunacion("B0000020", new Vacuna("Vacuna contra la paratuberculosis", "Control de la paratuberculosis o enfermedad de Johne, que afecta principalmente a los rumiantes", "Mycobacterium avium subsp. paratuberculosis"), new DateTime(2024, 8, 25)));
            Registros.Add(new RegistroVacunacion("B0000021", new Vacuna("Vacuna contra la leptospirosis", "Previene la leptospirosis, que puede causar insuficiencia renal", "Bacteria Leptospira"), new DateTime(2024, 9, 15)));
            Registros.Add(new RegistroVacunacion("B0000022", new Vacuna("Vacuna contra la brucelosis", "Control de la brucelosis, que puede causar abortos en los animales", "Bacteria Brucella"), new DateTime(2024, 10, 20)));
            Registros.Add(new RegistroVacunacion("B0000023", new Vacuna("Vacuna contra la clostridiosis", "Protege contra infecciones por Clostridium, que pueden ser fatales", "Bacteria Clostridium"), new DateTime(2024, 11, 10)));
            Registros.Add(new RegistroVacunacion("B0000024", new Vacuna("Vacuna IBR", "Protege contra la Rinotraqueitis Infecciosa Bovina", "Virus BHV-1"), new DateTime(2024, 12, 5)));
            Registros.Add(new RegistroVacunacion("B0000025", new Vacuna("Vacuna antirrábica", "Protege contra la rabia en todos los animales", "Virus de la rabia"), new DateTime(2025, 1, 25)));
            Registros.Add(new RegistroVacunacion("O0000001", new Vacuna("Vacuna contra la fiebre aftosa", "Prevención de fiebre aftosa, una enfermedad viral altamente contagiosa", "Virus de la fiebre aftosa"), new DateTime(2023, 1, 15)));
            Registros.Add(new RegistroVacunacion("O0000002", new Vacuna("Vacuna contra la fiebre aftosa", "Prevención de fiebre aftosa, una enfermedad viral altamente contagiosa", "Virus de la fiebre aftosa"), new DateTime(2023, 1, 15)));
            Registros.Add(new RegistroVacunacion("O0000003", new Vacuna("Vacuna contra la fiebre aftosa", "Prevención de fiebre aftosa, una enfermedad viral altamente contagiosa", "Virus de la fiebre aftosa"), new DateTime(2023, 1, 15)));
            Registros.Add(new RegistroVacunacion("O0000004", new Vacuna("Vacuna antirrábica", "Protege contra la rabia en todos los animales", "Virus de la rabia"), new DateTime(2023, 2, 15)));
            Registros.Add(new RegistroVacunacion("O0000005", new Vacuna("Vacuna antirrábica", "Protege contra la rabia en todos los animales", "Virus de la rabia"), new DateTime(2023, 2, 15)));
            Registros.Add(new RegistroVacunacion("O0000006", new Vacuna("Vacuna antirrábica", "Protege contra la rabia en todos los animales", "Virus de la rabia"), new DateTime(2023, 2, 15)));
            Registros.Add(new RegistroVacunacion("O0000007", new Vacuna("Vacuna contra la brucelosis", "Control de la brucelosis, que puede causar abortos en los animales", "Bacteria Brucella"), new DateTime(2023, 3, 15)));
            Registros.Add(new RegistroVacunacion("O0000008", new Vacuna("Vacuna contra la brucelosis", "Control de la brucelosis, que puede causar abortos en los animales", "Bacteria Brucella"), new DateTime(2023, 3, 15)));
            Registros.Add(new RegistroVacunacion("O0000009", new Vacuna("Vacuna contra la brucelosis", "Control de la brucelosis, que puede causar abortos en los animales", "Bacteria Brucella"), new DateTime(2023, 3, 15)));
            Registros.Add(new RegistroVacunacion("O0000010", new Vacuna("Vacuna contra la leptospirosis", "Previene la leptospirosis, que puede causar insuficiencia renal", "Bacteria Leptospira"), new DateTime(2023, 4, 15)));
            Registros.Add(new RegistroVacunacion("O0000011", new Vacuna("Vacuna contra la leptospirosis", "Previene la leptospirosis, que puede causar insuficiencia renal", "Bacteria Leptospira"), new DateTime(2023, 4, 15)));
            Registros.Add(new RegistroVacunacion("O0000012", new Vacuna("Vacuna contra la leptospirosis", "Previene la leptospirosis, que puede causar insuficiencia renal", "Bacteria Leptospira"), new DateTime(2023, 4, 15)));
            Registros.Add(new RegistroVacunacion("O0000013", new Vacuna("Vacuna contra el carbunco bacteridiano", "Protege contra el carbunco bacteridiano, una enfermedad mortal", "Bacillus anthracis"), new DateTime(2023, 5, 15)));
            Registros.Add(new RegistroVacunacion("O0000014", new Vacuna("Vacuna contra el carbunco bacteridiano", "Protege contra el carbunco bacteridiano, una enfermedad mortal", "Bacillus anthracis"), new DateTime(2023, 5, 15)));
            Registros.Add(new RegistroVacunacion("O0000015", new Vacuna("Vacuna contra el carbunco bacteridiano", "Protege contra el carbunco bacteridiano, una enfermedad mortal", "Bacillus anthracis"), new DateTime(2023, 5, 15)));
            Registros.Add(new RegistroVacunacion("O0000016", new Vacuna("Vacuna contra la clostridiosis", "Protege contra infecciones por Clostridium, que pueden ser fatales", "Bacteria Clostridium"), new DateTime(2023, 6, 15)));
            Registros.Add(new RegistroVacunacion("O0000017", new Vacuna("Vacuna contra la clostridiosis", "Protege contra infecciones por Clostridium, que pueden ser fatales", "Bacteria Clostridium"), new DateTime(2023, 6, 15)));
            Registros.Add(new RegistroVacunacion("O0000018", new Vacuna("Vacuna contra la clostridiosis", "Protege contra infecciones por Clostridium, que pueden ser fatales", "Bacteria Clostridium"), new DateTime(2023, 6, 15)));
            Registros.Add(new RegistroVacunacion("O0000019", new Vacuna("Vacuna contra la peste bovina", "Prevención de la peste bovina, una enfermedad viral erradicada pero con vacunación preventiva en áreas de riesgo", "Virus de la peste bovina"), new DateTime(2023, 7, 15)));
            Registros.Add(new RegistroVacunacion("O0000020", new Vacuna("Vacuna contra la peste bovina", "Prevención de la peste bovina, una enfermedad viral erradicada pero con vacunación preventiva en áreas de riesgo", "Virus de la peste bovina"), new DateTime(2023, 7, 15)));
            Registros.Add(new RegistroVacunacion("O0000021", new Vacuna("Vacuna contra la peste bovina", "Prevención de la peste bovina, una enfermedad viral erradicada pero con vacunación preventiva en áreas de riesgo", "Virus de la peste bovina"), new DateTime(2023, 7, 15)));
            Registros.Add(new RegistroVacunacion("O0000022", new Vacuna("Vacuna IBR", "Protege contra la Rinotraqueitis Infecciosa Bovina", "Virus BHV-1"), new DateTime(2023, 8, 15)));
            Registros.Add(new RegistroVacunacion("O0000023", new Vacuna("Vacuna IBR", "Protege contra la Rinotraqueitis Infecciosa Bovina", "Virus BHV-1"), new DateTime(2023, 8, 15)));
            Registros.Add(new RegistroVacunacion("O0000024", new Vacuna("Vacuna IBR", "Protege contra la Rinotraqueitis Infecciosa Bovina", "Virus BHV-1"), new DateTime(2023, 8, 15)));
            Registros.Add(new RegistroVacunacion("O0000025", new Vacuna("Vacuna contra la diarrea viral bovina", "Prevención de la diarrea viral bovina, que afecta a los bovinos de todas las edades", "Virus de la diarrea viral bovina"), new DateTime(2023, 9, 15)));


            foreach (Animal animal in Animales)
            {
                foreach (RegistroVacunacion registro in Registros)
                {
                    if (animal.Caravana == registro.Animal)
                    {
                        registro.ValidarEdad(animal.FechaNac);
                        AltaRegistro(registro);
                    }
                }
            }

        }

        //Asignación de animales a potreros
        public void AsignarAnimalesPotreros()
        {
            int totalPotrerosB = 5;
            int totalPotrerosO = 10;
            int animalesPorPotrero = 6;

            for (int potreroId = 0; potreroId < totalPotrerosB; potreroId++)
            {
                int inicioAnimal = potreroId * animalesPorPotrero;
                for (int j = 0; j < animalesPorPotrero; j++)
                {
                    string caravana = $"B{(inicioAnimal + j + 1).ToString("D7")}";
                    AsignarAnimalPotrero(potreroId, caravana);
                }
            }

            for (int potreroId = 5; potreroId < totalPotrerosO; potreroId++)
            {
                int inicioAnimal = potreroId * animalesPorPotrero - 30;
                for (int k = 0; k < animalesPorPotrero; k++)
                {
                    string caravana = $"O{(inicioAnimal + k + 1).ToString("D7")}";
                    AsignarAnimalPotrero(potreroId, caravana);
                }
            }

        }

        public void AsignarAnimalPotrero(int id, string caravana)
        {
            Potrero potrero = BuscarPotrero(id);
            Animal animal = BuscarAnimal(caravana);
            if (!potrero.Animales.Contains(animal) && potrero.Capacidad > 0)
            {
                potrero.Animales.Add(animal);
            }
        }

        //Precarga de vacunas
        private void PreCargarVacunas()
        {
            AltaVacuna(new Vacuna("Vacuna contra la fiebre aftosa", "Prevención de fiebre aftosa, una enfermedad viral altamente contagiosa", "Virus de la fiebre aftosa"));
            AltaVacuna(new Vacuna("Vacuna antirrábica", "Protege contra la rabia en todos los animales", "Virus de la rabia"));
            AltaVacuna(new Vacuna("Vacuna contra la brucelosis", "Control de la brucelosis, que puede causar abortos en los animales", "Bacteria Brucella"));
            AltaVacuna(new Vacuna("Vacuna contra la leptospirosis", "Previene la leptospirosis, que puede causar insuficiencia renal", "Bacteria Leptospira"));
            AltaVacuna(new Vacuna("Vacuna contra el carbunco bacteridiano", "Protege contra el carbunco bacteridiano, una enfermedad mortal", "Bacillus anthracis"));
            AltaVacuna(new Vacuna("Vacuna contra la clostridiosis", "Protege contra infecciones por Clostridium, que pueden ser fatales", "Bacteria Clostridium"));
            AltaVacuna(new Vacuna("Vacuna contra la peste bovina", "Prevención de la peste bovina, una enfermedad viral erradicada pero con vacunación preventiva en áreas de riesgo", "Virus de la peste bovina"));
            AltaVacuna(new Vacuna("Vacuna IBR", "Protege contra la Rinotraqueitis Infecciosa Bovina", "Virus BHV-1"));
            AltaVacuna(new Vacuna("Vacuna contra la diarrea viral bovina", "Prevención de la diarrea viral bovina, que afecta a los bovinos de todas las edades", "Virus de la diarrea viral bovina"));
            AltaVacuna(new Vacuna("Vacuna contra la paratuberculosis", "Control de la paratuberculosis o enfermedad de Johne, que afecta principalmente a los rumiantes", "Mycobacterium avium subsp. paratuberculosis"));
        }

        //Métodos utilizados para dar de alta a las distintas clases con sus respectivos metodos Buscar
        public void AltaPotrero(Potrero nuevoPotrero)
        {
            nuevoPotrero.Validar();
            if (!_potreros.Contains(nuevoPotrero))
            {
                _potreros.Add(nuevoPotrero);
            }
        }

        public void AltaPeon(Peon nuevoPeon)
        {
            nuevoPeon.Validar();
            if (!_empleados.Contains(nuevoPeon))
            {
                _empleados.Add(nuevoPeon);
            }

        }

        public void AltaVacuna(Vacuna nuevaVacuna)
        {
            nuevaVacuna.Validar();
            if (!_vacunas.Contains(nuevaVacuna))
            {
                _vacunas.Add(nuevaVacuna);
            }
        }

        public void AltaBovino(Bovino nuevoBovino)
        {
            nuevoBovino.Validar();
            if (BuscarBovino(nuevoBovino.Caravana) == null)
            {
                _animales.Add(nuevoBovino);
            }
            else
            {
                throw new Exception("Ya existe un bovino con esta caravana");
            }
        }
        public void AltaOvino(Ovino nuevoOvino)
        {
            nuevoOvino.Validar();
            if (!_animales.Contains(nuevoOvino))
            {
                _animales.Add(nuevoOvino);
            }
        }

        public void AltaCapataz(Capataz nuevoCapataz)
        {
            nuevoCapataz.Validar();
            if (!_empleados.Contains(nuevoCapataz))
            {
                _empleados.Add(nuevoCapataz);
            }

        }

        public void AltaRegistro(RegistroVacunacion nuevoRegistro)
        {
            nuevoRegistro.Validar();
            if (!_registrosVacunaciones.Contains(nuevoRegistro))
            {
                _registrosVacunaciones.Add(nuevoRegistro);
            }
            else
            {
            }
        }

        public void AltaTarea(string mail, Tarea nuevaTarea)
        {
            nuevaTarea.Validar();
            Peon peon = BuscarPeon(mail);
            if (!peon.Tareas.Contains(nuevaTarea))
            {
                peon.Tareas.Add(nuevaTarea);
            }
        }

        //Dada una caravana, devuelve al bovino con la caravana correspondiente
        public Bovino BuscarBovino(string caravana)
        {
            Bovino bovBuscado = null;
            int i = 0;
            while (i < _animales.Count && bovBuscado == null)
            {
                if (_animales[i].Caravana == caravana)
                {
                    bovBuscado = (Bovino)Animales[i];

                }
                i++;
            }
            return bovBuscado;
        }
        //Dada una caravana, devuelve al animal con la caravana correspondiente
        public Animal BuscarAnimal(string caravana)
        {
            Animal animalBuscado = null;
            int i = 0;
            while (i < _animales.Count && animalBuscado == null)
            {
                if (_animales[i].Caravana == caravana)
                {
                    animalBuscado = Animales[i];
                }
                i++;
            }
            return animalBuscado;
        }

        //Dado un email, devuelve al empleado con el email correspondiente
        public Peon BuscarPeon(string email)
        {
            Peon peonBuscado = null;
            int i = 0;
            while (i < _empleados.Count && peonBuscado == null)
            {
                if (_empleados[i].Email == email && Empleados[i] is Peon)
                {
                    peonBuscado = (Peon)_empleados[i];
                }
                i++;
            }
            return peonBuscado;
        }

        //Dada una id, devuelve al Potrero con la id correspondiente
        public Potrero BuscarPotrero(int id)
        {
            Potrero potreroBuscado = null;
            int i = 0;
            while (i < _potreros.Count && potreroBuscado == null)
            {
                if (_potreros[i].Id == id)
                {
                    potreroBuscado = _potreros[i];
                }
                i++;
            }
            return potreroBuscado;
        }

        //Devuelve una lista de las tareas ordenadas por fecha pactada ascendente
        public List<Tarea> DevolverTareasOrdenadas(string email)
        {
            BuscarPeon(email).Tareas.Sort();
            return BuscarPeon(email).Tareas;
        }

        //Devuelve una lista de potreros ordenados por capacidad ascendente y cantidad de animales descendente
        public List<Potrero> DevolverPotrerosOrdenados()
        {
            _potreros.Sort();
            return _potreros;
        }
        //Método para modificar una tarea utilizado para completar la misma
        public void ModificarTarea(Tarea tarea, Tarea tareaBuscada, string comentario)
        {
            tareaBuscada.FueCompletada = true;
            tareaBuscada.FechaCierre = DateTime.Now;
            tareaBuscada.Comentario = comentario;
        }
        //Dada una id de tarea devuelve un peon al cual fue asignada dicha tarea
        public Peon ObtenerPeonPorTareaId(int tareaId)
        {
            Empleado peonBuscado = null;
            foreach (Empleado empleado in Empleados)
            {
                if (empleado is Peon peon)
                {
                    foreach (Tarea tarea in peon.Tareas)
                    {
                        if (tarea.Id == tareaId)
                        {
                            return peon;
                        }
                    }
                }
            }
            return null;
        }

        //Dada una id devuelve la tarea correspondiente
        public Tarea BuscarTarea(int id)
        {
            Tarea tareaBuscada = null;
            int i = 0;
            while (i < _tareasAsignadas.Count && tareaBuscada == null)
            {
                if (_tareasAsignadas[i].Id == id)
                {
                    tareaBuscada = _tareasAsignadas[i];
                }
                i++;
            }
            return tareaBuscada;
        }
        //Dada un nombre devuelve la vacuna correspondiente
        public Vacuna BuscarVacuna(string nombre)
        {
            Vacuna vacBuscada = null;
            int i = 0;
            while(i < _vacunas.Count && vacBuscada == null)
            {
                if (_vacunas[i].Nombre == nombre)
                {
                    vacBuscada = _vacunas[i];
                }
                i++;
            }
            return vacBuscada;
        }
        //Dados un mail y contraseña devuelve el empleado con estos datos asignados
        public Empleado BuscarEmpleado(string email, string contrasenia)
        {
            Empleado empleadoBuscado = null;
            int i = 0;
            while (i < _empleados.Count && empleadoBuscado == null)
            {
                if (_empleados[i].Email == email && _empleados[i].Contrasenia == contrasenia)
                {
                    empleadoBuscado = _empleados[i];
                }
                i++;
            }
            return empleadoBuscado;
        }
        //Devuelve una lista de animales según el tipo seleccionado y con un peso mayor al dado
        public List<Animal> AnimalesDeTipoMayorPeso(string tipo, decimal peso)
        {
            List<Animal> animalesFiltrados = new List<Animal>();
            foreach (Animal animal in Animales)
            {
                string tipoAnimal = "";
                if (animal is Bovino)
                {
                    tipoAnimal = "Bovino";
                }
                else
                {
                    tipoAnimal = "Ovino";
                }
                if (animal.PesoActual > peso && tipoAnimal == tipo)
                {
                    animalesFiltrados.Add(animal);
                }
            }
            return animalesFiltrados;
        }
    }
}
