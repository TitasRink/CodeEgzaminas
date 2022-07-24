using Bussiness.AccesssData;
using FrameworkData.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIHospital.Controllers
{
    public class HospitalAPI : Controller
    {
        [Route("[Controller]")]
    
        [HttpPost]
            public void CreatDepartment(string name, string address)
            {
            var result = new DepartmentInfo();
            result.CreatDepartment(name, address);
            }
        [HttpPost("Create dep with doc and pat")]
        public void CreatDepartment(string depName, string depAddress,int docNumber, int patNumber)
            {
            var result = new DepartmentInfo();
            result.CreatDepartment(depName, depAddress, docNumber, patNumber);
            }

        [HttpPost("Change Doctors Departments ID")]
        public void AddDoctorToDepartment(int depId, int doctorId)
            {
            var result = new DoctorInfo();
            result.AddToDepartment(depId, doctorId);
            }

        [HttpGet("List of Departments")]
        public List<DepartmentModel> GetDepartment()
            {
            DepartmentInfo dep = new DepartmentInfo();
            var result = dep.GetDepartment();
            return result;
            }

        [HttpPost("Create Doctor and add to dep")]
        public void CreatDoctor(string name, string address, int age, int depId)
            {
            var result = new DoctorInfo();
            result.CreatDoctor(name, address, age, depId);
            }

        [HttpPost("Create Patient")]
        public void CreatPatient(string name, string address)
            {
            var result = new PatientInfo();
            result.CreatPatient(name, address);
            }

        [HttpGet("List of Department-Doctors")]
        public List<DoctorModel> GetDoctors(int departmentID)
            {
            DoctorInfo dep = new DoctorInfo();
            var result = dep.GetDepartmentDoctors(departmentID);
            return result;
            }

        [HttpPost("Add Patient to Doctor")]
        public void AddPatient(int docNum, int patNum)
            {
            var result = new DoctorInfo();
            result.AddPatientToDoctor(docNum, patNum);
            }
        
        [HttpGet("List Patient by Doctor ID")]
        public List<DoctorModel> GetPatientListFromDoctor(int departmentID)
            {
            DoctorInfo dep = new DoctorInfo();
            var result = dep.Doctorinfo(departmentID);
            return result;
            }
        [HttpDelete("Delete Department by ID")]
        public void RemoveDepartament(int depId)
            {
            var result = new DepartmentInfo();
            result.DeleteDepartament(depId);
            }
        [HttpGet("Show all department patients")]
        public List<PatientModel> ShowDepPatients(int departmentID)
        {
            PatientInfo dep = new PatientInfo();
            var result = dep.ShowDepPatients(departmentID);
            return result;
        }
        [HttpGet("Show all doctor patients")]
        public List<PatientModel> ShowDocPatients(int docId)
        {
            PatientInfo dep = new PatientInfo();
            var result = dep.ShowDocPatients(docId);
            return result;
        }
    }
}
