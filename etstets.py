import unittest
from unittest.mock import patch

def ask_addition_question(x):
    return int(input(f"What is {x} + {x}? "))

class TestAdditionQuestions(unittest.TestCase):
    
    @patch('builtins.input', side_effect=['0', '2', '4', '6', '8', '10', '12', '14', '16'])
    def test_ask_addition_question(self, x):
       
        for x in range(0, 9):
            expected_answer = x + x  
            user_answer = ask_addition_question(x)  
            self.assertEqual(user_answer, expected_answer)  

if __name__ == '__main__':
    unittest.main()
8