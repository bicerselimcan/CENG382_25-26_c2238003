using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotNetWeek5App.Models;
using System.Collections.Generic;
using System.Linq;

namespace DotNetWeek5App.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ClassInformationModel NewClass { get; set; } = new ClassInformationModel();

        public static List<ClassInformationModel> ClassList { get; set; } = new List<ClassInformationModel>();

// Edit kısmında hata aldığım için GPT'den yardım aldım
        private static int _idCounter = 1; // ID sayacı için

        public void OnGet()
        {
            if (NewClass == null)
            {
                NewClass = new ClassInformationModel();
            }
        }

        public IActionResult OnPostAdd()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            NewClass.Id = _idCounter++; // ID ataması için
            ClassList.Add(NewClass);
            NewClass = new ClassInformationModel(); // formu sıfırlamak için

            return RedirectToPage();
        }

        public IActionResult OnPostDelete(int id)
        {
            var item = ClassList.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                ClassList.Remove(item);
            }

            return RedirectToPage();
        }

        public IActionResult OnPostEdit(int id)
        {
            var item = ClassList.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                NewClass = new ClassInformationModel
                {
                    Id = item.Id,
                    ClassName = item.ClassName,
                    StudentCount = item.StudentCount,
                    Description = item.Description
                };
            }

            return Page();
        }

        public IActionResult OnPostUpdate()
        {
            var existing = ClassList.FirstOrDefault(x => x.Id == NewClass.Id);
            if (existing != null)
            {
                existing.ClassName = NewClass.ClassName;
                existing.StudentCount = NewClass.StudentCount;
                existing.Description = NewClass.Description;
            }

            NewClass = new ClassInformationModel(); // formu temizlemek için
            return RedirectToPage();
        }
    }
}