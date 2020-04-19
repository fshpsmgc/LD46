using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DevStats{
    public int GameDesignSkill;
    public int ProgrammingSkill;
    public int ArtSkill;
    public int SoundSkill;

    public float Delay;
    public int Budget;

    public float maxDelay;
    public int maxPoints;

    //TODO: Make it properly
    //Delay = maxDelay - Point
    public void Generate() {
        Delay = maxDelay;
        for(int i = 0; i < maxPoints; i++){
            int skill = Random.Range(0,6);
            switch(skill){
                case 0:
                    GameDesignSkill++;
                    break;
                case 1:
                    ProgrammingSkill++;
                    break;
                case 2:
                    ArtSkill++;
                    break;
                case 3:
                    SoundSkill++;
                    break;
                case 4:
                    Delay--;
                    break;
                default:
                    Budget += Random.Range(85, 125);
                    break;
            }
        }

        GameDesignSkill = Random.Range(0, 10);
        ProgrammingSkill = Random.Range(0, 10);
        ArtSkill = Random.Range(0, 10);
        SoundSkill = Random.Range(0, 10);
        Delay = Random.Range(1f, 7f);
    }
}

public class Developer : MonoBehaviour
{   
        static string[] names = {
        "Wade",
        "Dave",
        "Seth",
        "Ivan",
        "Riley",
        "Gilbert",
        "Jorge",
        "Dan",
        "Brian",
        "Roberto",
        "Ramon",
        "Miles",
        "Liam",
        "Nathaniel",
        "Ethan",
        "Lewis",
        "Milton",
        "Claude",
        "Joshua",
        "Glen",
        "Harvey",
        "Blake",
        "Antonio",
        "Connor",
        "Julian",
        "Aidan",
        "Harold",
        "Conner",
        "Peter",
        "Hunter",
        "Eli",
        "Alberto",
        "Carlos",
        "Shane",
        "Aaron",
        "Marlin",
        "Paul",
        "Ricardo",
        "Hector",
        "Alexis",
        "Adrian",
        "Kingston",
        "Douglas",
        "Gerald",
        "Joey",
        "Johnny",
        "Charlie",
        "Scott",
        "Martin",
        "Tristin",
        "Troy",
        "Tommy",
        "Rick",
        "Victor",
        "Jessie",
        "Neil",
        "Ted",
        "Nick",
        "Wiley",
        "Morris",
        "Clark",
        "Stuart",
        "Orlando",
        "Keith",
        "Marion",
        "Marshall",
        "Noel",
        "Everett",
        "Romeo",
        "Sebastian",
        "Stefan",
        "Robin",
        "Clarence",
        "Sandy",
        "Ernest",
        "Samuel",
        "Benjamin",
        "Luka",
        "Fred",
        "Albert",
        "Greyson",
        "Terry",
        "Cedric",
        "Joe",
        "Paul",
        "George",
        "Bruce",
        "Christopher",
        "Mark",
        "Ron",
        "Craig",
        "Philip",
        "Jimmy",
        "Arthur",
        "Jaime",
        "Perry",
        "Harold",
        "Jerry",
        "Shawn",
        "Walter",
        "Daisy",
        "Deborah",
        "Isabel",
        "Stella",
        "Debra",
        "Beverly",
        "Vera",
        "Angela",
        "Lucy",
        "Lauren",
        "Janet",
        "Loretta",
        "Tracey",
        "Beatrice",
        "Sabrina",
        "Melody",
        "Chrysta",
        "Christina",
        "Vicki",
        "Molly",
        "Alison",
        "Miranda",
        "Stephanie",
        "Leona",
        "Katrina",
        "Mila",
        "Teresa",
        "Gabriela",
        "Ashley",
        "Nicole",
        "Valentina",
        "Rose",
        "Juliana",
        "Alice",
        "Kathie",
        "Gloria",
        "Luna",
        "Phoebe",
        "Angelique",
        "Graciela",
        "Gemma",
        "Katelynn",
        "Danna",
        "Luisa",
        "Julie",
        "Olive",
        "Carolina",
        "Harmony",
        "Hanna",
        "Anabelle",
        "Francesca",
        "Whitney",
        "Skyla",
        "Nathalie",
        "Sophie",
        "Hannah",
        "Silvia",
        "Sophia",
        "Della",
        "Myra",
        "Blanca",
        "Bethany",
        "Robyn",
        "Traci",
        "Desiree",
        "Laverne",
        "Patricia",
        "Alberta",
        "Lynda",
        "Cara",
        "Brandi",
        "Janessa",
        "Claudia",
        "Rosa",
        "Sandra",
        "Eunice",
        "Kayla",
        "Kathryn",
        "Rosie",
        "Monique",
        "Maggie",
        "Hope",
        "Alexia",
        "Lucille",
        "Odessa",
        "Amanda",
        "Kimberly",
        "Blanche",
        "Tyra",
        "Helena",
        "Kayleigh",
        "Lucia",
        "Janine",
        "Maribel",
        "Camille",
        "Alisa",
        "Vivian",
        "Lesley",
        "Rachelle",
        "Kianna"
    };

    static string[] surnames = {
        "Williams",
        "Harris",
        "Thomas",
        "Robinson",
        "Walker",
        "Scott",
        "Nelson",
        "Mitchell",
        "Morgan",
        "Cooper",
        "Howard",
        "Davis",
        "Miller",
        "Martin",
        "Smith",
        "Anderson",
        "White",
        "Perry",
        "Clark",
        "Richards",
        "Wheeler",
        "Warburton",
        "Stanley",
        "Holland",
        "Terry",
        "Shelton",
        "Miles",
        "Lucas",
        "Fletcher",
        "Parks",
        "Norris",
        "Guzman",
        "Daniel",
        "Newton",
        "Potter",
        "Francis",
        "Erickson",
        "Norman",
        "Moody",
        "Lindsey",
        "Gross",
        "Sherman",
        "Simon",
        "Jones",
        "Brown",
        "Garcia",
        "Rodriguez",
        "Lee",
        "Young",
        "Hall",
        "Allen",
        "Lopez",
        "Green",
        "Gonzalez",
        "Baker",
        "Adams",
        "Perez",
        "Campbell",
        "Shaw",
        "Gordon",
        "Burns",
        "Warren",
        "Long",
        "Mcdonald",
        "Gibson",
        "Ellis",
        "Fisher",
        "Reynolds",
        "Jordan",
        "Hamilton",
        "Ford",
        "Graham",
        "Griffin",
        "Russell",
        "Foster",
        "Butler",
        "Simmons",
        "Flores",
        "Bennett",
        "Sanders",
        "Hughes",
        "Bryant",
        "Patterson",
        "Matthews",
        "Jenkins",
        "Watkins",
        "Ward",
        "Murphy",
        "Bailey",
        "Bell",
        "Cox",
        "Martinez",
        "Evans",
        "Rivera",
        "Peterson",
        "Gomez",
        "Murray",
        "Tucker",
        "Hicks",
        "Crawford",
        "Mason",
        "Rice",
        "Black",
        "Knight",
        "Arnold",
        "Wagner",
        "Mosby",
        "Ramirez",
        "Coleman",
        "Powell",
        "Singh",
        "Patel",
        "Wood",
        "Wright",
        "Stephens",
        "Eriksen",
        "Cook",
        "Roberts",
        "Holmes",
        "Kennedy",
        "Saunders",
        "Fisher",
        "Hunter",
        "Reid",
        "Stewart",
        "Carter",
        "Phillips",
        "Spencer",
        "Howell",
        "Alvarez",
        "Little",
        "Jacobs",
        "Foreman",
        "Knowles",
        "Meadows",
        "Richmond",
        "Valentine",
        "Dudley",
        "Woodward",
        "Weasley",
        "Livingston",
        "Sheppard",
        "Kimmel",
        "Noble",
        "Leach",
        "Gentry",
        "Lara",
        "Pace",
        "Trujillo",
        "Grant",
    };

    [SerializeField] bool generateStatsOnStart;
    public DevStats stats;
    public static int Count = 0;
    private float timeSinceApplying;
    private GameController controller;
    public string DevName;
    public GameObject Panel;

    void Awake(){
        if(generateStatsOnStart){
            stats.Generate();
            DevName = $"{names[Random.Range(0, names.Length)]} {surnames[Random.Range(0, surnames.Length)]}";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
        Count++;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceApplying += Time.deltaTime;
        if (timeSinceApplying >= stats.Delay) {
            controller.ApplyPoints(stats);
            timeSinceApplying = 0;
        }
    }

    public DevStats GetStats(){
        return stats;
    }

    private void OnDestroy() {
        Destroy(Panel);
    }
}
