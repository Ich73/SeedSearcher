﻿#include "Data.h"
#include "Util.h"
#include "Const.h"

_u64 g_TempMatrix[256];
_u64 g_InputMatrix[64]; 
_u64 g_ConstantTermVector;
_u64 g_Coefficient[64];
_u64 g_AnswerFlag[64];
int g_FreeBit[64];
int g_FreeId[64];

_u64 g_CoefficientData[0x1000000];
_u64 g_SearchPattern[0x1000000];

_u64 l_Temp[256];

void InitializeTransformationMatrix()
{
	for (int i = 0; i < 256; ++i)
	{
		g_TempMatrix[i] = Const::c_N[i];
		l_Temp[i] = 0;
	}
	for (int i = 0; i < 64; i++) {
		g_InputMatrix[i] = 0;
		g_Coefficient[i] = 0;
		g_AnswerFlag[i] = 0;
		g_FreeBit[i] = 0;
		g_FreeId[i] = 0;
	}

	for (int i = 0; i < 0x1000000; i++) {
		g_CoefficientData[i] = 0;
		g_SearchPattern[i] = 0;
	}
}
void ProceedTransformationMatrix()
{
	for (int i = 0; i < 256; ++i)
	{
		l_Temp[i] = g_TempMatrix[i];
	}

	for (int y = 0; y < 128; ++y)
	{
		g_TempMatrix[y * 2] = 0;
		g_TempMatrix[y * 2 + 1] = 0;
		for (int x = 0; x < 64; ++x)
		{
			_u64 t0 = 0;
			_u64 t1 = 0;
			for (int i = 0; i < 64; ++i)
			{
				if ((Const::c_N[y * 2] & (1ull << (63 - i))) != 0
					&& (l_Temp[i * 2] & (1ull << (63 - x))) != 0)
				{
					t0 = 1 - t0;
				}
				if ((Const::c_N[y * 2 + 1] & (1ull << (63 - i))) != 0
					&& (l_Temp[(i + 64) * 2] & (1ull << (63 - x))) != 0)
				{
					t0 = 1 - t0;
				}

				if ((Const::c_N[y * 2] & (1ull << (63 - i))) != 0
					&& (l_Temp[i * 2 + 1] & (1ull << (63 - x))) != 0)
				{
					t1 = 1 - t1;
				}
				if ((Const::c_N[y * 2 + 1] & (1ull << (63 - i))) != 0
					&& (l_Temp[(i + 64) * 2 + 1] & (1ull << (63 - x))) != 0)
				{
					t1 = 1 - t1;
				}
			}
			g_TempMatrix[y * 2] |= (t0 << (63 - x));
			g_TempMatrix[y * 2 + 1] |= (t1 << (63 - x));
		}
	}
}
_u64 GetMatrixMultiplier(int index)
{
	return g_TempMatrix[index * 2 + 1];
}

short GetMatrixConst(int index)
{
	return (short)GetSignature(g_TempMatrix[index * 2] & Const::c_XoroshiroConst);
}

int CalculateInverseMatrix(int length)
{
	for (int i = 0; i < length; ++i)
	{
		g_AnswerFlag[i] = (1ull << (length - 1 - i));
	}

	int skip = 0;
	for (int i = 0; i < 64; ++i)
	{
		g_FreeBit[i] = 0;
	}
	int rank;
	for (rank = 0; rank + skip < 64;)
	{
		_u64 top = (1ull << (63 - (rank + skip)));
		bool rankUpFlag = false;
		for (int i = rank; i < length; ++i)
		{
			if ((g_InputMatrix[i] & top) != 0)
			{
				for (int a = 0; a < length; ++a)
				{
					if (a == i) continue;
					if ((g_InputMatrix[a] & top) != 0)
					{
						g_InputMatrix[a] ^= g_InputMatrix[i];
						g_AnswerFlag[a] ^= g_AnswerFlag[i];
					}
				}
				_u64 swapM = g_InputMatrix[rank];
				_u64 swapF = g_AnswerFlag[rank];
				g_InputMatrix[rank] = g_InputMatrix[i];
				g_AnswerFlag[rank] = g_AnswerFlag[i];
				g_InputMatrix[i] = swapM;
				g_AnswerFlag[i] = swapF;

				++rank;
				rankUpFlag = true;
				break;
			}
		}
		if (rankUpFlag == false)
		{
			g_FreeBit[rank + skip] = 1;
			g_FreeId[skip] = rank + skip;
			++skip;
		}
	}

	for (int i = 0; i < rank; ++i)
	{
		g_Coefficient[i] = 0;
		for (int a = 0; a < skip; ++a)
		{
			g_Coefficient[i] |= (g_InputMatrix[i] & (1ull << (63 - g_FreeId[a]))) >> (rank + a - g_FreeId[a]);
		}
	}
	return 64 - skip;
}

void CalculateCoefficientData(int length)
{
	unsigned int max = (1 << (64 - length));
	for (unsigned int search = 0; search < max; ++search)
	{
		g_CoefficientData[search] = 0;
		g_SearchPattern[search] = 0;
		int offset = 0;
		for (int i = 0; i < length; ++i)
		{
			while (g_FreeBit[i + offset] > 0)
			{
				++offset;
			}
			g_CoefficientData[search] |= GetSignature(g_Coefficient[i] & search) << (63 - (i + offset));
		}
		for (int a = 0; a < (64 - length) + offset; ++a)
		{
			g_SearchPattern[search] |= ((_u64)search & (1ull << (64 - length - 1 - a))) << ((length + a) - g_FreeId[a]);
		}
	}
}