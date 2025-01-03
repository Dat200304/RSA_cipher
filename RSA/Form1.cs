﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RSA
{
    public partial class Form1 : Form
    {
        private RSACryptoServiceProvider rsa;

        public Form1()
        {
            InitializeComponent();
            rsa = new RSACryptoServiceProvider(2048);  // Sử dụng RSA với độ dài khóa 2048 bit
        }

        // Nút Generate Keys
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo public và private key
                string publicKey = rsa.ToXmlString(false);  // Public key
                string privateKey = rsa.ToXmlString(true);  // Private key

                // Lấy tham số RSA
                RSAParameters parameters = rsa.ExportParameters(true);

                // Lấy giá trị p, q và e
                BigInteger p = new BigInteger(parameters.P);  // Chuyển đổi mảng byte của p thành số nguyên
                BigInteger q = new BigInteger(parameters.Q);  // Chuyển đổi mảng byte của q thành số nguyên
                BigInteger exponent = new BigInteger(parameters.Exponent);  // Chuyển đổi mảng byte của e thành số nguyên


                // Hiển thị khóa và tham số
                textBox1.Text = publicKey;
                textBox2.Text = privateKey;
                textBox7.Text = "p: " + p.ToString();  // Hiển thị p dưới dạng số nguyên
                textBox8.Text = "q: " + q.ToString();  // Hiển thị q dưới dạng số nguyên
                textBox9.Text = "e: " + exponent.ToString();  // Hiển thị e dưới dạng số nguyên
            }
            catch (Exception ex)
            {
                MessageBox.Show("Key generation failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Nút Encrypt
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string plainText = textBox3.Text; // Lấy dữ liệu cần mã hóa
                if (string.IsNullOrEmpty(plainText))
                {
                    MessageBox.Show("Please enter text to encrypt.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sử dụng public key để mã hóa
                rsa.FromXmlString(textBox1.Text);  // Lấy public key từ textBox1
                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(plainText), false);
                string encryptedText = Convert.ToBase64String(encryptedData);

                // Hiển thị kết quả đã mã hóa
                textBox5.Text = encryptedText;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Decrypt

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string encryptedText = textBox4.Text; // Lấy dữ liệu cần giải mã
                if (string.IsNullOrEmpty(encryptedText))
                {
                    MessageBox.Show("Please enter encrypted text to decrypt.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sử dụng private key để giải mã
                rsa.FromXmlString(textBox2.Text);  // Lấy private key từ textBox2
                byte[] encryptedData = Convert.FromBase64String(encryptedText);
                byte[] decryptedData = rsa.Decrypt(encryptedData, false);
                string decryptedText = Encoding.UTF8.GetString(decryptedData);

                // Hiển thị kết quả đã giải mã
                textBox6.Text = decryptedText;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
