using System;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            Hospital hospital = new Hospital();

            Doctor doctor1 = new Doctor(1, "Іваненко Іван", "Терапевт");
            Doctor doctor2 = new Doctor(2, "Петренко Петро", "Хірург");
            Doctor doctor3 = new Doctor(3, "Сидоренко Сидір", "Педіатр");
            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);
            hospital.AddDoctor(doctor3);

            Patient patient1 = new Patient(1, "Олена Коваль", 25);
            Patient patient2 = new Patient(2, "Микола Шевченко", 40);
            Patient patient3 = new Patient(3, "Анна Бондар", 32);
            Patient patient4 = new Patient(4, "Василь Гнатюк", 55);
            hospital.RegisterPatient(patient1);
            hospital.RegisterPatient(patient2);
            hospital.RegisterPatient(patient3);
            hospital.RegisterPatient(patient4);

            HospitalRoom room1 = new HospitalRoom(101, 2);
            HospitalRoom room2 = new HospitalRoom(102, 2);
            HospitalRoom room3 = new HospitalRoom(103, 1);
            hospital.CreateRoom(room1);
            hospital.CreateRoom(room2);
            hospital.CreateRoom(room3);

            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 102);
            hospital.HospitalizePatient(4, 103);

            hospital.AddMedicalRecord(new MedicalRecord(patient1, doctor1, DateTime.Now.AddDays(-2), "Первинний огляд, призначено лікування."));
            hospital.AddMedicalRecord(new MedicalRecord(patient2, doctor2, DateTime.Now.AddDays(-1), "Операція пройшла успішно."));
            hospital.AddMedicalRecord(new MedicalRecord(patient1, doctor3, DateTime.Now, "Консультація педіатра."));

            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            hospital.GetStatistics();
        }
    }
}