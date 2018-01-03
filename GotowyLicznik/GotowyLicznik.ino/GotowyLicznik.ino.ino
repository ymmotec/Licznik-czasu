
const int buttonPin = 2;    
const int ledPin =  13;     


int obecny = 0;         
int poprzedni = 0;
int counter = 0;

void setup() {
  
  pinMode(ledPin, OUTPUT);
 
  pinMode(buttonPin, INPUT);
  Serial.begin(9600);
  Serial.setTimeout(10);
}

void loop() {
  
  obecny = digitalRead(buttonPin);
  counter += 1;
  if(obecny != poprzedni)
  {
    if(obecny == HIGH)
    {
      counter = 0;
      Serial.println(1);
      poprzedni = obecny;
      
      digitalWrite(ledPin, HIGH);
    }
    else
    {
      counter = 0;
      poprzedni = obecny;
      digitalWrite(buttonPin, obecny);
      digitalWrite(ledPin, LOW);
    }
  }

    
    delay(200);

}
