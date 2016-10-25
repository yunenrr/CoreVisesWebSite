var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRST"
                    + "UVWXYZ1234567890,.:;/-_%!¿?$#[]{} ";
var alphabetChar = alphabet.split('');

function encrypt(text,  key)
{
    var newText = "";
    var textChar = text.split('');
    var keyChar = key.split('');
    var k = 0;
    var keyPosition = 0;
    var letterPosition = 0;
    var newPosition = 0;
    for (i = 0; i < text.length; i++) {
        letterPosition = findLetter(textChar[i]);
        keyPosition = findLetter(keyChar[k]);
        newPosition = letterPosition + keyPosition;
        if(newPosition > alphabet.length)
        {
            newPosition = newPosition - alphabet.length;
        }
        newText += alphabetChar[newPosition-1];
        k++;
        if (k == key.length)
        {
            k = 0;
        }
    }
    return newText;
}


function  decrypting(text, key)
{
    var newText = "";
    var  textChar = text.split('');
    var keyChar = key.split('');
    var k = 0;
    var keyPosition = 0;
    var letterPosition = 0;
    var newPosition = 0;
    for (h = 0; h < text.length; h++)
    {
        letterPosition = findLetter(textChar[h]);
        keyPosition = findLetter(keyChar[k]);
        newPosition = letterPosition - keyPosition;
        if (newPosition < 1)
        {
            newPosition = alphabet.length+ newPosition;
        }
        newText += alphabetChar[newPosition - 1];
        k++;
        if (k == key.length)
        {
            k = 0;
        }
    }
    return newText;
}

function findLetter( letter)
{
    var pos = 0;

    for(j = 0; j < alphabet.length; j++)
    {
        if (letter == alphabetChar[j])
        {
            pos = j + 1;
            j = alphabet.length;
        }
    }
    return pos;
}

