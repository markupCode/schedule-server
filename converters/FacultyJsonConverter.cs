using System.Collections.Generic;
using Newtonsoft.Json.Linq;

using ScheduleServer.Models;

namespace ScheduleServer.Converters {
    public class FacultyJsonConverter : IModelJsonConverter<Faculty> {
        public Faculty Convert(JToken value) {
            var faculty = new Faculty();

            faculty.Code = value["id"].Value<string>();
            faculty.FullName = value["title"].Value<string>();
            faculty.ShortName = value["name"].Value<string>();

            return faculty;
        }
    }
}