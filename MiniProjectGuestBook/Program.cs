

using MiniProjectGuestBook;

string partyName;
int partySize;


string name;
int totalAttending = 0;
bool partyDone = false;
List<string> partyNames = new List<string>();

do
{
    name = Controls.GetName();
    partySize = Controls.GetGroupSize();
    totalAttending = Controls.AddParty(totalAttending, partySize);

    if (name.ToLower() != "")
    {
        partyNames.Add(name);
    }
    else
    {
        partyDone = true;
    }
} while (partyDone != true);

Controls.SeeLog(partyNames, totalAttending);
