bool isClockwise = true; // 초기 회전 방향 설정 (시계방향)
bool isMoving = false; // 모터 움직임 상태
int distanceMoved = 0;
int distanceMoved1 = 0; // 움직인 거리
int distanceMoved2 = 0;
int distanceMoved3 = 0;
int distanceMoved4 = 0;
void timeIntervalmoving(int step);
void moveMotorClock(int steps);
void moveMotorClock1(int steps1);
void moveMotorClock2(int steps2);
void moveMotorClock3(int steps3);
void moveMotorClock4(int steps4);
void resetRail();
void resetRail1();
void resetRail2();
void resetRail3();
void resetRail4();

int movesteps[] = {0, 32, 67, 99, 134, 168, 201, 234, 268, 300, 334, 368, 402, 436, 470, 502, 536, 570, 604, 633, 670, 701,
734, 767, 800, 834, 868, 899, 933, 966, 1000, 1033, 1065, 1098, 1131, 1164, 1197, 1230, 1264, 1297, 1332, 1363,
1397, 1430, 1464, 1497, 1533, 1564, 1598, 1631, 1666, 1699, 1730, 1764, 1797, 1830, 1864, 1897, 1930, 1966,
2000, 2033, 2065, 2098, 2131, 2164, 2197, 2230, 2265, 2297, 2330, 2363, 2397, 2430, 2464, 2497, 2530, 2564,
2598, 2631, 2664, 2697, 2734};

void setup() {
  Serial.begin(9600);
  pinMode(3, OUTPUT); //1번레일 
  pinMode(2, OUTPUT); //1번레일
  pinMode(5, OUTPUT); //2번레일
  pinMode(4, OUTPUT); //2번레일
  pinMode(7, OUTPUT); //3번레일
  pinMode(6, OUTPUT); //3번레일
  pinMode(9, OUTPUT); //4번레일
  pinMode(8, OUTPUT); //4번레일
  digitalWrite(3, HIGH); // 초기 회전 방향 설정
  digitalWrite(4, HIGH); // 초기 회전 방향 설정
  digitalWrite(7, HIGH); // 초기 회전 방향 설정
  digitalWrite(9, HIGH); // 초기 회전 방향 설정
}

void loop() {
    if (Serial.available() > 0) { //시리얼 버퍼 안에 데이터가 있는지 확인
    String receivedData = Serial.readStringUntil('\n'); // \n까지 데이터 읽기
    // 1번째 레일 버튼 동작 구역
    if (receivedData.startsWith("A")) { // 'A'로 시작하는지 확인
      char command1 = receivedData.charAt(1); //'A' 다음으로 오는 숫자로 명령 수행
      switch (command1) {
        case '0': //C#에서는 'A0'에 해당하는 부분
          if (!isMoving) {
            moveMotorClock1(1000);
          }
          break; //30cm 버튼을 선택한 경우
        case '1':
          if (!isMoving) {
            moveMotorClock1(2000);
          }
          break; //60cm 버튼을 선택한 경우
        case '2':
          if (!isMoving) {
            moveMotorClock1(2734);
          }
          break; //60cm 이상 버튼을 선택한 경우(75cm)
        case '3':
          if (!isMoving) {
            resetRail1(); //Reset 버튼 
          }
        }
      }
    //2번째 레일 버튼 동작 구역
    else if (receivedData.startsWith("B")) //B로 시작하는지 확인
    {
      char command2 = receivedData.charAt(1);
      switch (command2) {
        case '0': //C#에서는 'B0'에 해당하는 부분
          if (!isMoving) {
            moveMotorClock2(1000);
          }
          break; //30cm 버튼을 선택한 경우
        case '1':
          if (!isMoving) {
            moveMotorClock2(2000);
          }
          break; //60cm 버튼을 선택한 경우
        case '2':
          if (!isMoving) {
            moveMotorClock2(2734);
          }
          break; //82cm
        case '3':
          if (!isMoving) {
            resetRail2(); //Reset 버튼 
        }
      }
    }
    //3번째 레일 버튼 동작 구역
    else if (receivedData.startsWith("C"))
    {
      char command3 = receivedData.charAt(1);
      switch (command3) {
        case '0': //C#에서는 'C0'에 해당하는 부분
          if (!isMoving) {
            moveMotorClock3(1000);
          }
          break; //30cm 버튼을 선택한 경우
        case '1':
          if (!isMoving) {
            moveMotorClock3(2000);
          }
          break; //60cm 버튼을 선택한 경우
        case '2':
          if (!isMoving) {
            moveMotorClock3(2734);
          }
          break; //60cm 이상 버튼을 선택한 경우(75cm)
        case '3':
          if (!isMoving) {
            resetRail3(); //Reset 버튼 
          }
        }
      }
    

    //4번째 레일 버튼 동작 구역
    else if(receivedData.startsWith("D"))
    {
      char command4 = receivedData.charAt(1);
      switch (command4) {
        case '0': //C#에서는 'D0'에 해당하는 부분
          if (!isMoving) {
            moveMotorClock4(1000);
          }
          break; //30cm 버튼을 선택한 경우
        case '1':
          if (!isMoving) {
            moveMotorClock4(2000);
          }
          break; //60cm 버튼을 선택한 경우
        case '2':
          if (!isMoving) {
            moveMotorClock4(2734);
          }
          break; //60cm 이상 버튼을 선택한 경우(75cm)
        case '3':
          if (!isMoving) {
            resetRail4(); //Reset 버튼 
          }
        }
      }

    //동시에 모든 레일 버튼 동작 구역
    else if(receivedData.startsWith("K"))
    {
      char command5 = receivedData.charAt(1);
      switch (command5) {
        case '0': //C#에서는 'K0'에 해당하는 부분
          if (!isMoving) {
            moveMotorClock(1000);
          }
          break; //30cm 버튼을 선택한 경우
        case '1':
          if (!isMoving) {
            moveMotorClock(2000);
          }
          break; //60cm 버튼을 선택한 경우
        case '2':
          if (!isMoving) {
            moveMotorClock(2734);
          }
          break; //60cm 이상 버튼을 선택한 경우(75cm)
        case '3':
          if (!isMoving) {
            resetRail(); //Reset 버튼 
          }
        }
      }

    //레일마다의 사용자입력 값 받는 구역
    //1번째 레일 사용자 입력 값  
    else if (receivedData.startsWith("E"))
    {
      int value1 = receivedData.substring(1).toInt(); // 나머지 문자열을 정수로 변환
      if(!isMoving) {
          moveMotorClock1(movesteps[value1]);
      } 
    }
    //2번째 레일 사용자 입력 값
    else if (receivedData.startsWith("F"))
    {
      int value2 = receivedData.substring(1).toInt();
      if(!isMoving) {
        moveMotorClock2(movesteps[value2]);
      }
    }
    //3번째 레일 사용자 입력 값
    else if (receivedData.startsWith("G"))
    {
      int value3 = receivedData.substring(1).toInt();
      if(!isMoving) {
        moveMotorClock3(movesteps[value3]);
      }
    }

    //4번째 레일 사용자 입력 값
    else if (receivedData.startsWith("H"))
    {
      int value4 = receivedData.substring(1).toInt();
      if(!isMoving) {
        moveMotorClock4(movesteps[value4]);
      }
    }

    //모든 레일 동시 이동 사용자 입력 값
    else if (receivedData.startsWith("Y"))
    {
      int value5 = receivedData.substring(1).toInt();
      if(!isMoving) {
        moveMotorClock(movesteps[value5]);
      }
    }

    else if (receivedData.startsWith("M"))
    {
      if(!isMoving) {
        timeIntervalmoving(1000);
        delay(5000);
        timeIntervalmoving(1000);
        delay(5000);
        timeIntervalmoving(734);
        delay(5000);
        resetRail();
      }
    }
  }
}  
      //'A','B','C','D'로 시작하는 명령이 아닌 경우는 사용자입력으로 수행
      //else{ 
      //int userinput = receivedData.toInt(); //문자열을 정수로 변환
       // if(!isMoving) {
        //moveMotorClock1(movesteps[userinput]); //사용자입력을 받아서 모터 이동
        //}
      //}
    
  void timeIntervalmoving(int step) {
  digitalWrite(3,HIGH); // 오른쪽으로 이동
  digitalWrite(4,HIGH); // 오른쪽으로 이동
  digitalWrite(7,HIGH);
  digitalWrite(9,HIGH);
  isMoving = true;
  for (int i = 0; i<step; i++) {
    digitalWrite(2, LOW);
    digitalWrite(5, LOW);
    digitalWrite(6, LOW);
    digitalWrite(8, LOW);
    delay(1);
    digitalWrite(2, HIGH);
    digitalWrite(5, HIGH);
    digitalWrite(6, HIGH);
    digitalWrite(8, HIGH);
    delay(1);
  }
  isMoving = false;
  distanceMoved += step;
}

  void moveMotorClock(int steps) {
  digitalWrite(3,HIGH); // 오른쪽으로 이동
  digitalWrite(4,HIGH); // 오른쪽으로 이동
  digitalWrite(7,HIGH);
  digitalWrite(9,HIGH);
  isMoving = true;
  for (int i = 0; i < steps; i++) {
    digitalWrite(2, LOW);
    digitalWrite(5, LOW);
    digitalWrite(6, LOW);
    digitalWrite(8, LOW);
    delay(1);
    digitalWrite(2, HIGH);
    digitalWrite(5, HIGH);
    digitalWrite(6, HIGH);
    digitalWrite(8, HIGH);
    delay(1);
  }
  isMoving = false;
  distanceMoved += steps;
}

  void moveMotorClock1(int steps1) {
  digitalWrite(3,HIGH); // 오른쪽으로 이동
  //digitalWrite(4,HIGH); // 오른쪽으로 이동
  isMoving = true;
  for (int i = 0; i < steps1; i++) {
    digitalWrite(2, LOW);
    //digitalWrite(5, LOW);
    delay(1);
    digitalWrite(2, HIGH);
    //digitalWrite(5, HIGH);
    delay(1);
  }
  isMoving = false;
  distanceMoved1 += steps1;
}

 void moveMotorClock2(int steps2) {
  //digitalWrite(3,HIGH); // 오른쪽으로 이동
  digitalWrite(4,HIGH); // 오른쪽으로 이동
  isMoving = true;
  for (int i = 0; i < steps2; i++) {
    //digitalWrite(2, LOW);
    digitalWrite(5, LOW);
    delay(1);
    //digitalWrite(2, HIGH);
    digitalWrite(5, HIGH);
    delay(1);
  }
  isMoving = false;
  distanceMoved2 += steps2;
}

 void moveMotorClock3(int steps3) {
  digitalWrite(7,HIGH); // 오른쪽으로 이동
  isMoving = true;
  for (int i = 0; i < steps3; i++) {
    digitalWrite(6, LOW);
    delay(1);
    digitalWrite(6, HIGH);
    delay(1);
  }
  isMoving = false;
  distanceMoved3 += steps3;
}

 void moveMotorClock4(int steps4) {
  digitalWrite(9,HIGH);
  isMoving = true;
  for (int i = 0; i < steps4; i++) {
    digitalWrite(8,LOW);
    delay(1);
    digitalWrite(8,HIGH);
    delay(1);
  }
  isMoving = false;
  distanceMoved4 += steps4;
}

void resetRail() {
  digitalWrite(3,LOW);
  digitalWrite(4,LOW); //역방향으로 이동
  digitalWrite(7,LOW);
  digitalWrite(9,LOW);
  if (isClockwise) {
    for (int i = 0; i < distanceMoved; i++) {
      digitalWrite(2,HIGH);
      digitalWrite(5,HIGH);
      digitalWrite(6,HIGH);
      digitalWrite(8,HIGH);
      delay(1);
      digitalWrite(2,LOW);
      digitalWrite(5,LOW);
      digitalWrite(6,LOW);
      digitalWrite(8,LOW);
      delay(1);
    }
  }
  distanceMoved = 0;
  isMoving = false;
}

void resetRail1() {
  digitalWrite(3,LOW);
  //digitalWrite(4,LOW); //역방향으로 이동
  if (isClockwise) {
    for (int i = 0; i < distanceMoved1; i++) {
      digitalWrite(2,HIGH);
      //digitalWrite(5,HIGH);
      delay(1);
      digitalWrite(2,LOW);
      //digitalWrite(5,LOW);
      delay(1);
    }
  }
  distanceMoved1 = 0;
  isMoving = false;
}

void resetRail2() {
  //digitalWrite(3,LOW);
  digitalWrite(4,LOW); //역방향으로 이동
  if (isClockwise) {
    for (int i = 0; i < distanceMoved2; i++) {
      //digitalWrite(2,HIGH);
      digitalWrite(5,HIGH);
      delay(1);
      //digitalWrite(2,LOW);
      digitalWrite(5,LOW);
      delay(1);
    }
  }
  distanceMoved2 = 0;
  isMoving = false;
}

void resetRail3() {
  digitalWrite(7,LOW);
  //digitalWrite(3,LOW);
  //digitalWrite(4,LOW); //역방향으로 이동
  if (isClockwise) {
    for (int i = 0; i < distanceMoved3; i++) {
      digitalWrite(6,HIGH);
      delay(1);
      digitalWrite(6,LOW);
      delay(1);
    }
  }
  distanceMoved3 = 0;
  isMoving = false;
}

void resetRail4() {
  digitalWrite(9,LOW);
  if (isClockwise) {
    for (int i = 0; i < distanceMoved4; i++) {
      digitalWrite(8,HIGH);
      delay(1);
      digitalWrite(8,LOW);
      delay(1);
    }
  }
  distanceMoved4 = 0;
  isMoving = false;
}
