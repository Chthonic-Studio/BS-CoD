using UnityEngine;

namespace Unity.Sentis
{
    struct TensorProperties
    {
        public int k_ID_Ptr;
        public int k_ID_WidthMask;
        public int k_ID_WidthShift;
        public int k_ID_StrideAxis;
        public int k_ID_DimAxis;
        public int k_ID_DimBlocked;
        public int k_ID_Strides;
        public int k_ID_Shape;
        public int k_ID_Rank;

        public TensorProperties(string name)
        {
            k_ID_Ptr = Shader.PropertyToID($"{name}ptr");
            k_ID_WidthMask = Shader.PropertyToID($"WidthMask{name}");
            k_ID_WidthShift = Shader.PropertyToID($"WidthShift{name}");
            k_ID_StrideAxis = Shader.PropertyToID($"StrideAxis{name}");
            k_ID_DimAxis = Shader.PropertyToID($"DimAxis{name}");
            k_ID_DimBlocked = Shader.PropertyToID($"DimBlocked{name}");
            k_ID_Strides = Shader.PropertyToID($"Strides{name}");
            k_ID_Shape = Shader.PropertyToID($"Shape{name}");
            k_ID_Rank = Shader.PropertyToID($"Rank{name}");
        }
    }

    class ShaderPropertyID
    {
        public static readonly int k_ID_X_height = Shader.PropertyToID("X_height");
        public static readonly int k_ID_X_width = Shader.PropertyToID("X_width");
        public static readonly int k_ID_O_height = Shader.PropertyToID("O_height");
        public static readonly int k_ID_O_width = Shader.PropertyToID("O_width");
        public static readonly int k_ID_O_channelsDiv4 = Shader.PropertyToID("O_channelsDiv4");
        public static readonly int k_ID_xOffset = Shader.PropertyToID("xOffset");
        public static readonly int k_ID_yOffset = Shader.PropertyToID("yOffset");
        public static readonly int k_ID_Xptr = Shader.PropertyToID("Xptr");
        public static readonly int k_ID_Yptr = Shader.PropertyToID("Yptr");
        public static readonly int k_ID_Optr = Shader.PropertyToID("Optr");
        public static readonly int k_ID_shapeA = Shader.PropertyToID("shapeA");
        public static readonly int k_ID_stridesA = Shader.PropertyToID("stridesA");
        public static readonly int k_ID_shapeB = Shader.PropertyToID("shapeB");
        public static readonly int k_ID_stridesB = Shader.PropertyToID("stridesB");
        public static readonly int k_ID_shapeO = Shader.PropertyToID("shapeO");
        public static readonly int k_ID_stridesO = Shader.PropertyToID("stridesO");
        public static readonly int k_ID_A = Shader.PropertyToID("A");
        public static readonly int k_ID_B = Shader.PropertyToID("B");
        public static readonly int k_ID_S = Shader.PropertyToID("S");
        public static readonly int k_ID_M = Shader.PropertyToID("M");
        public static readonly int k_ID_N = Shader.PropertyToID("N");
        public static readonly int k_ID_K = Shader.PropertyToID("K");
        public static readonly int k_ID_AM = Shader.PropertyToID("AM");
        public static readonly int k_ID_AN = Shader.PropertyToID("AN");
        public static readonly int k_ID_BM = Shader.PropertyToID("BM");
        public static readonly int k_ID_BN = Shader.PropertyToID("BN");
        public static readonly int k_ID_CB = Shader.PropertyToID("CB");
        public static readonly int k_ID_CM = Shader.PropertyToID("CM");
        public static readonly int k_ID_CN = Shader.PropertyToID("CN");
        public static readonly int k_ID_rank = Shader.PropertyToID("rank");
        public static readonly int k_ID_Bptr = Shader.PropertyToID("Bptr");
        public static readonly int k_ID_b = Shader.PropertyToID("b");
        public static readonly int k_ID_s = Shader.PropertyToID("s");
        public static readonly int k_ID_W_width = Shader.PropertyToID("W_width");
        public static readonly int k_ID_W_height = Shader.PropertyToID("W_height");
        public static readonly int k_ID_Wptr = Shader.PropertyToID("Wptr");
        public static readonly int k_ID_Zptr = Shader.PropertyToID("Zptr");
        public static readonly int k_ID_X_length = Shader.PropertyToID("X_length");
        public static readonly int k_ID_diagonalK = Shader.PropertyToID("diagonalK");
        public static readonly int k_ID_O_depth = Shader.PropertyToID("O_depth");
        public static readonly int k_ID_X_depth = Shader.PropertyToID("X_depth");
        public static readonly int k_ID_K_depth = Shader.PropertyToID("K_depth");
        public static readonly int k_ID_K_height = Shader.PropertyToID("K_height");
        public static readonly int k_ID_K_width = Shader.PropertyToID("K_width");
        public static readonly int k_ID_K_channelsDivGroupDiv4 = Shader.PropertyToID("K_channelsDivGroupDiv4");
        public static readonly int k_ID_K_mDivGroup = Shader.PropertyToID("K_mDivGroup");
        public static readonly int k_ID_Kptr = Shader.PropertyToID("Kptr");
        public static readonly int k_ID_O_batch = Shader.PropertyToID("O_batch");
        public static readonly int k_ID_O_channels = Shader.PropertyToID("O_channels");
        public static readonly int k_ID_KWEptr = Shader.PropertyToID("KWEptr");
        public static readonly int k_ID_X_channels = Shader.PropertyToID("X_channels");
        public static readonly int k_ID_X_channelsDiv4 = Shader.PropertyToID("X_channelsDiv4");
        public static readonly int k_ID__Stride = Shader.PropertyToID("_Stride");
        public static readonly int k_ID__Pad = Shader.PropertyToID("_Pad");
        public static readonly int k_ID__Dilation = Shader.PropertyToID("_Dilation");
        public static readonly int k_ID__MinValue = Shader.PropertyToID("_MinValue");
        public static readonly int k_ID_outChannels = Shader.PropertyToID("outChannels");
        public static readonly int k_ID_outHeight = Shader.PropertyToID("outHeight");
        public static readonly int k_ID_outWidth = Shader.PropertyToID("outWidth");
        public static readonly int k_ID_inHeight = Shader.PropertyToID("inHeight");
        public static readonly int k_ID_inWidth = Shader.PropertyToID("inWidth");
        public static readonly int k_ID_kernelHeight = Shader.PropertyToID("kernelHeight");
        public static readonly int k_ID_kernelWidth = Shader.PropertyToID("kernelWidth");
        public static readonly int k_ID_padY = Shader.PropertyToID("padY");
        public static readonly int k_ID_padX = Shader.PropertyToID("padX");
        public static readonly int k_ID_strideY = Shader.PropertyToID("strideY");
        public static readonly int k_ID_strideX = Shader.PropertyToID("strideX");
        public static readonly int k_ID_scale = Shader.PropertyToID("scale");
        public static readonly int k_ID_bias = Shader.PropertyToID("bias");
        public static readonly int k_ID_inDepth = Shader.PropertyToID("inDepth");
        public static readonly int k_ID_outBatch = Shader.PropertyToID("outBatch");
        public static readonly int k_ID_outDepth = Shader.PropertyToID("outDepth");
        public static readonly int k_ID_blocksize = Shader.PropertyToID("blocksize");
        public static readonly int k_ID_stride = Shader.PropertyToID("stride");
        public static readonly int k_ID_pad = Shader.PropertyToID("pad");
        public static readonly int k_ID_pool = Shader.PropertyToID("pool");
        public static readonly int k_ID_poolX = Shader.PropertyToID("poolX");
        public static readonly int k_ID_poolY = Shader.PropertyToID("poolY");
        public static readonly int k_ID_SpatialDims = Shader.PropertyToID("SpatialDims");
        public static readonly int k_ID_SpatialDimsO = Shader.PropertyToID("SpatialDimsO");
        public static readonly int k_ID_GlobalSpatialDims = Shader.PropertyToID("GlobalSpatialDims");
        public static readonly int k_ID_ReducedDim = Shader.PropertyToID("ReducedDim");
        public static readonly int k_ID_InnerDim = Shader.PropertyToID("InnerDim");
        public static readonly int k_ID_X2ptr = Shader.PropertyToID("X2ptr");
        public static readonly int k_ID_O2ptr = Shader.PropertyToID("O2ptr");
        public static readonly int k_ID_IsFirstDispatch = Shader.PropertyToID("IsFirstDispatch");
        public static readonly int k_ID__Groups = Shader.PropertyToID("_Groups");
        public static readonly int k_ID_batch = Shader.PropertyToID("batch");
        public static readonly int k_ID_channels = Shader.PropertyToID("channels");
        public static readonly int k_ID_spatialDims = Shader.PropertyToID("spatialDims");
        public static readonly int k_ID_epsilon = Shader.PropertyToID("epsilon");
        public static readonly int k_ID_rangeStartFloat = Shader.PropertyToID("rangeStartFloat");
        public static readonly int k_ID_rangeDeltaFloat = Shader.PropertyToID("rangeDeltaFloat");
        public static readonly int k_ID_O_length = Shader.PropertyToID("O_length");
        public static readonly int k_ID_rangeStartInt = Shader.PropertyToID("rangeStartInt");
        public static readonly int k_ID_rangeDeltaInt = Shader.PropertyToID("rangeDeltaInt");
        public static readonly int k_ID_OIntptr = Shader.PropertyToID("OIntptr");
        public static readonly int k_ID_alpha = Shader.PropertyToID("alpha");
        public static readonly int k_ID_f1 = Shader.PropertyToID("f1");
        public static readonly int k_ID_f2 = Shader.PropertyToID("f2");
        public static readonly int k_ID_beta = Shader.PropertyToID("beta");
        public static readonly int k_ID_gamma = Shader.PropertyToID("gamma");
        public static readonly int k_ID_minV = Shader.PropertyToID("minV");
        public static readonly int k_ID_maxV = Shader.PropertyToID("maxV");
        public static readonly int k_ID_lambd = Shader.PropertyToID("lambd");
        public static readonly int k_ID_innerLength = Shader.PropertyToID("innerLength");
        public static readonly int k_ID_outerLength = Shader.PropertyToID("outerLength");
        public static readonly int k_ID_reduceLength = Shader.PropertyToID("reduceLength");
        public static readonly int k_ID_maxK = Shader.PropertyToID("maxK");
        public static readonly int k_ID_outStridesA = Shader.PropertyToID("outStridesA");
        public static readonly int k_ID_sumStridesA = Shader.PropertyToID("sumStridesA");
        public static readonly int k_ID_sumSize = Shader.PropertyToID("sumSize");
        public static readonly int k_ID_sumRank = Shader.PropertyToID("sumRank");
        public static readonly int k_ID_outRank = Shader.PropertyToID("outRank");
        public static readonly int k_ID_outStridesB = Shader.PropertyToID("outStridesB");
        public static readonly int k_ID_sumStridesB = Shader.PropertyToID("sumStridesB");
        public static readonly int k_ID_elementSize = Shader.PropertyToID("elementSize");
        public static readonly int k_ID_starts = Shader.PropertyToID("starts");
        public static readonly int k_ID_steps = Shader.PropertyToID("steps");
        public static readonly int k_ID_start = Shader.PropertyToID("start");
        public static readonly int k_ID_lengthO = Shader.PropertyToID("lengthO");
        public static readonly int k_ID_strideLower = Shader.PropertyToID("strideLower");
        public static readonly int k_ID_strideUpperX = Shader.PropertyToID("strideUpperX");
        public static readonly int k_ID_strideUpperO = Shader.PropertyToID("strideUpperO");
        public static readonly int k_ID_Beta = Shader.PropertyToID("Beta");
        public static readonly int k_ID_permutations = Shader.PropertyToID("permutations");
        public static readonly int k_ID_endLength = Shader.PropertyToID("endLength");
        public static readonly int k_ID_endLengthX = Shader.PropertyToID("endLengthX");
        public static readonly int k_ID_indicesLength = Shader.PropertyToID("indicesLength");
        public static readonly int k_ID_axisDim = Shader.PropertyToID("axisDim");
        public static readonly int k_ID_startLength = Shader.PropertyToID("startLength");
        public static readonly int k_ID_axisDimIndices = Shader.PropertyToID("axisDimIndices");
        public static readonly int k_ID_reduction = Shader.PropertyToID("reduction");
        public static readonly int k_ID_updatesLength = Shader.PropertyToID("updatesLength");
        public static readonly int k_ID_indexRemapDim = Shader.PropertyToID("indexRemapDim");
        public static readonly int k_ID_trailing = Shader.PropertyToID("trailing");
        public static readonly int k_ID_Iptr = Shader.PropertyToID("Iptr");
        public static readonly int k_ID_Uptr = Shader.PropertyToID("Uptr");
        public static readonly int k_ID_UIntptr = Shader.PropertyToID("UIntptr");
        public static readonly int k_ID_depth = Shader.PropertyToID("depth");
        public static readonly int k_ID_offValue = Shader.PropertyToID("offValue");
        public static readonly int k_ID_onValue = Shader.PropertyToID("onValue");
        public static readonly int k_ID_offValueInt = Shader.PropertyToID("offValueInt");
        public static readonly int k_ID_onValueInt = Shader.PropertyToID("onValueInt");
        public static readonly int k_ID_rankO = Shader.PropertyToID("rankO");
        public static readonly int k_ID_numRois = Shader.PropertyToID("numRois");
        public static readonly int k_ID_inputChannels = Shader.PropertyToID("inputChannels");
        public static readonly int k_ID_inputHeight = Shader.PropertyToID("inputHeight");
        public static readonly int k_ID_inputWidth = Shader.PropertyToID("inputWidth");
        public static readonly int k_ID_outputHeight = Shader.PropertyToID("outputHeight");
        public static readonly int k_ID_outputWidth = Shader.PropertyToID("outputWidth");
        public static readonly int k_ID_samplingRatio = Shader.PropertyToID("samplingRatio");
        public static readonly int k_ID_spatialScale = Shader.PropertyToID("spatialScale");
        public static readonly int k_ID_seed = Shader.PropertyToID("seed");
        public static readonly int k_ID_mean = Shader.PropertyToID("mean");
        public static readonly int k_ID_low = Shader.PropertyToID("low");
        public static readonly int k_ID_high = Shader.PropertyToID("high");
        public static readonly int k_ID_hiddenSize = Shader.PropertyToID("hiddenSize");
        public static readonly int k_ID_batchSize = Shader.PropertyToID("batchSize");
        public static readonly int k_ID_Pptr = Shader.PropertyToID("Pptr");
        public static readonly int k_ID_XsixWTptr = Shader.PropertyToID("XsixWTptr");
        public static readonly int k_ID_HtxRTptr = Shader.PropertyToID("HtxRTptr");
        public static readonly int k_ID_XIntptr = Shader.PropertyToID("XIntptr");
        public static readonly int k_ID_unrolledDispatchArgs = Shader.PropertyToID("unrolledDispatchArgs");
        public static readonly int k_ID_X_strideW = Shader.PropertyToID("X_strideW");
        public static readonly int k_ID_X_strideH = Shader.PropertyToID("X_strideH");
        public static readonly int k_ID_X_strideC = Shader.PropertyToID("X_strideC");
        public static readonly int k_ID_CoordOrigin = Shader.PropertyToID("CoordOrigin");
        public static readonly int k_ID_ChannelSwizzleR = Shader.PropertyToID("ChannelSwizzleR");
        public static readonly int k_ID_ChannelSwizzleG = Shader.PropertyToID("ChannelSwizzleG");
        public static readonly int k_ID_ChannelSwizzleB = Shader.PropertyToID("ChannelSwizzleB");
        public static readonly int k_ID_ChannelSwizzleA = Shader.PropertyToID("ChannelSwizzleA");
        public static readonly int k_ID_ChannelScale = Shader.PropertyToID("ChannelScale");
        public static readonly int k_ID_ChannelBias = Shader.PropertyToID("ChannelBias");
        public static readonly int k_ID_O_strideW = Shader.PropertyToID("O_strideW");
        public static readonly int k_ID_O_strideH = Shader.PropertyToID("O_strideH");
        public static readonly int k_ID_O_strideC = Shader.PropertyToID("O_strideC");
        public static readonly int k_ID_shapeX = Shader.PropertyToID("shapeX");
        public static readonly int k_ID_stridesX = Shader.PropertyToID("stridesX");
        public static readonly int k_ID_shapeS = Shader.PropertyToID("shapeS");
        public static readonly int k_ID_stridesS = Shader.PropertyToID("stridesS");
        public static readonly int k_ID_outLengths = Shader.PropertyToID("outLengths");
        public static readonly int k_ID_outStrides = Shader.PropertyToID("outStrides");
        public static readonly int k_ID_sumLengths = Shader.PropertyToID("sumLengths");
        public static readonly int k_ID_sumStrides = Shader.PropertyToID("sumStrides");
        public static readonly int k_ID_shapeC = Shader.PropertyToID("shapeC");
        public static readonly int k_ID_stridesC = Shader.PropertyToID("stridesC");
        public static readonly int k_ID_offsetX = Shader.PropertyToID("offsetX");
        public static readonly int k_ID_offsetO = Shader.PropertyToID("offsetO");
        public static readonly int k_ID_count = Shader.PropertyToID("count");
        public static readonly int k_ID_strideO = Shader.PropertyToID("strideO");
        public static readonly int k_ID_strideK = Shader.PropertyToID("strideK");
        public static readonly int k_ID_inputGroupedChannels = Shader.PropertyToID("inputGroupedChannels");
        public static readonly int k_ID_outputGroupedChannels = Shader.PropertyToID("outputGroupedChannels");
        public static readonly int k_ID_memValueFloat = Shader.PropertyToID("memValueFloat");
        public static readonly int k_ID_memValueInt = Shader.PropertyToID("memValueInt");
        public static readonly int k_ID_xStride = Shader.PropertyToID("xStride");
        public static readonly int k_ID_yStride = Shader.PropertyToID("yStride");
        public static readonly int k_ID_clipValue = Shader.PropertyToID("clipValue");
        public static readonly int k_ID_fActivation = Shader.PropertyToID("fActivation");
        public static readonly int k_ID_fAlpha = Shader.PropertyToID("fAlpha");
        public static readonly int k_ID_fBeta = Shader.PropertyToID("fBeta");
        public static readonly int k_ID_gActivation = Shader.PropertyToID("gActivation");
        public static readonly int k_ID_gAlpha = Shader.PropertyToID("gAlpha");
        public static readonly int k_ID_gBeta = Shader.PropertyToID("gBeta");
        public static readonly int k_ID_hActivation = Shader.PropertyToID("hActivation");
        public static readonly int k_ID_hAlpha = Shader.PropertyToID("hAlpha");
        public static readonly int k_ID_hBeta = Shader.PropertyToID("hBeta");
        public static readonly int k_ID_YHptr = Shader.PropertyToID("YHptr");
        public static readonly int k_ID_YCptr = Shader.PropertyToID("YCptr");
        public static readonly int k_ID_bOffset = Shader.PropertyToID("bOffset");
        public static readonly int k_ID_pOffset = Shader.PropertyToID("pOffset");
        public static readonly int k_ID_SequenceLensptr = Shader.PropertyToID("SequenceLensptr");
        public static readonly int k_ID_seqIndex = Shader.PropertyToID("seqIndex");
        public static readonly int k_ID_shapeY = Shader.PropertyToID("shapeY");
        public static readonly int k_ID_stridesY = Shader.PropertyToID("stridesY");
        public static readonly int k_ID_O_tex2D = Shader.PropertyToID("O_tex2D");
        public static readonly int k_ID_X_tex2D = Shader.PropertyToID("X_tex2D");
        public static readonly int k_ID_StrideZ = Shader.PropertyToID("StrideZ");
        public static readonly int k_ID_StrideY = Shader.PropertyToID("StrideY");
        public static readonly int k_ID_StrideX = Shader.PropertyToID("StrideX");
        public static readonly int k_ID_PadZ = Shader.PropertyToID("PadZ");
        public static readonly int k_ID_PadY = Shader.PropertyToID("PadY");
        public static readonly int k_ID_PadX = Shader.PropertyToID("PadX");
        public static readonly int k_ID_PoolY = Shader.PropertyToID("PoolY");
        public static readonly int k_ID_PoolX = Shader.PropertyToID("PoolX");
        public static readonly int k_ID_DilationZ = Shader.PropertyToID("DilationZ");
        public static readonly int k_ID_DilationY = Shader.PropertyToID("DilationY");
        public static readonly int k_ID_DilationX = Shader.PropertyToID("DilationX");
        public static readonly int k_ID_Groups = Shader.PropertyToID("Groups");
        public static readonly int k_ID_Alpha = Shader.PropertyToID("Alpha");
        public static readonly int k_ID_Normalization = Shader.PropertyToID("Normalization");
        public static readonly int k_ID_BlockSize = Shader.PropertyToID("BlockSize");
        public static readonly int k_ID_Scale = Shader.PropertyToID("Scale");
        public static readonly int k_ID_Bias = Shader.PropertyToID("Bias");
        public static readonly int k_ID_Sptr = Shader.PropertyToID("Sptr");
        public static readonly int k_ID_inputForget = Shader.PropertyToID("inputForget");
        public static readonly int k_ID_detectNegative = Shader.PropertyToID("detectNegative");
        public static readonly int k_ID_detectPositive = Shader.PropertyToID("detectPositive");
        public static readonly int k_ID_inputSpatialSize = Shader.PropertyToID("inputSpatialSize");
        public static readonly int k_ID_inputBatchOffset = Shader.PropertyToID("inputBatchOffset");
        public static readonly int k_ID_outputSpatialSize = Shader.PropertyToID("outputSpatialSize");
        public static readonly int k_ID_normalizeOHeight = Shader.PropertyToID("normalizeOHeight");
        public static readonly int k_ID_normalizeOWidth = Shader.PropertyToID("normalizeOWidth");
        public static readonly int k_ID_outputChannels = Shader.PropertyToID("outputChannels");
        public static readonly int k_ID_outputBatch = Shader.PropertyToID("outputBatch");
        public static readonly int k_ID_LengthO = Shader.PropertyToID("LengthO");
        public static readonly int k_ID_MaxBlockIndexX = Shader.PropertyToID("MaxBlockIndexX");
        public static readonly int k_ID_DimO = Shader.PropertyToID("DimO");
        public static readonly int k_ID_DimX = Shader.PropertyToID("DimX");
        public static readonly int k_ID_Pad = Shader.PropertyToID("Pad");
        public static readonly int k_ID_XIndices = Shader.PropertyToID("XIndices");
        public static readonly int k_ID_OIndices = Shader.PropertyToID("OIndices");

        public static readonly int k_ID_StrideAxis = Shader.PropertyToID("StrideAxis");
        public static readonly int k_ID_rankX = Shader.PropertyToID("rankX");
        public static readonly int k_ID_rankIndices = Shader.PropertyToID("rankIndices");
        public static readonly int k_ID_shapeIndices = Shader.PropertyToID("shapeIndices");
        public static readonly int k_ID_stridesIndices = Shader.PropertyToID("stridesIndices");
        public static readonly int k_ID_iStart = Shader.PropertyToID("iStart");
        public static readonly int k_ID_iEndIndices = Shader.PropertyToID("iEndIndices");
        public static readonly int k_ID_iEndX = Shader.PropertyToID("iEndX");
        public static readonly int k_ID_iEndMin = Shader.PropertyToID("iEndMin");
        public static readonly int k_ID_iStartB = Shader.PropertyToID("iStartB");
        public static readonly int k_ID_iEndB = Shader.PropertyToID("iEndB");
        public static readonly int k_ID_stridesToAxis = Shader.PropertyToID("stridesToAxis");
        public static readonly int k_ID_SplitStart = Shader.PropertyToID("SplitStart");
        public static readonly int k_ID_SplitLength = Shader.PropertyToID("SplitLength");
        public static readonly int k_ID_ConcatLengthA = Shader.PropertyToID("ConcatLengthA");
        public static readonly int k_ID_SpatialSizeX = Shader.PropertyToID("SpatialSizeX");
        public static readonly int k_ID_DimAxis = Shader.PropertyToID("DimAxis");
        public static readonly int k_ID_NumIndices = Shader.PropertyToID("NumIndices");
        public static readonly int k_ID_SliceLength = Shader.PropertyToID("SliceLength");
        public static readonly int k_ID_OffsetX = Shader.PropertyToID("OffsetX");
        public static readonly int k_ID_Stride0X = Shader.PropertyToID("Stride0X");
        public static readonly int k_ID_Stride1X = Shader.PropertyToID("Stride1X");
        public static readonly int k_ID_Channels = Shader.PropertyToID("Channels");
        public static readonly int k_ID_WidthX = Shader.PropertyToID("WidthX");
        public static readonly int k_ID_HeightX = Shader.PropertyToID("HeightX");
        public static readonly int k_ID_WidthO = Shader.PropertyToID("WidthO");
        public static readonly int k_ID_HeightO = Shader.PropertyToID("HeightO");
        public static readonly int k_ID_StrideWidthO = Shader.PropertyToID("StrideWidthO");
        public static readonly int k_ID_StrideHeightO = Shader.PropertyToID("StrideHeightO");
        public static readonly int k_ID_StrideC = Shader.PropertyToID("StrideC");
        public static readonly int k_ID_DimC = Shader.PropertyToID("DimC");
        public static readonly int k_ID_maxXIndex = Shader.PropertyToID("maxXIndex");
        public static readonly int k_ID_maxWIndex = Shader.PropertyToID("maxWIndex");
        public static readonly int k_ID_maxBIndex = Shader.PropertyToID("maxBIndex");
        public static readonly int k_ID_maxKIndex = Shader.PropertyToID("maxKIndex");
        public static readonly int k_ID_K_heightDiv4 = Shader.PropertyToID("K_heightDiv4");
        public static readonly int k_ID_K_widthDiv4 = Shader.PropertyToID("K_widthDiv4");
        public static readonly int k_ID_StrideK = Shader.PropertyToID("StrideK");
        public static readonly int k_ID_Stride = Shader.PropertyToID("Stride");
        public static readonly int k_ID_Dilation = Shader.PropertyToID("Dilation");
        public static readonly int k_ID_MaxLengthX = Shader.PropertyToID("MaxLengthX");
        public static readonly int k_ID_MaxLengthK = Shader.PropertyToID("MaxLengthK");
        public static readonly int k_ID_StrideO = Shader.PropertyToID("StrideO");
        public static readonly int k_ID_StrideFeaturesO = Shader.PropertyToID("StrideFeaturesO");
        public static readonly int k_ID_strideHeight = Shader.PropertyToID("strideHeight");
        public static readonly int k_ID_strideWidth = Shader.PropertyToID("strideWidth");
        public static readonly int k_ID_padHeight = Shader.PropertyToID("padHeight");
        public static readonly int k_ID_padWidth = Shader.PropertyToID("padWidth");
        public static readonly int k_ID_dilationHeight = Shader.PropertyToID("dilationHeight");
        public static readonly int k_ID_dilationWidth = Shader.PropertyToID("dilationWidth");
        public static readonly int k_ID_inputChannelsSize = Shader.PropertyToID("inputChannelsSize");
        public static readonly int k_ID_outputChannelsSize = Shader.PropertyToID("outputChannelsSize");
        public static readonly int k_ID_kernelChannelSize = Shader.PropertyToID("kernelChannelSize");
        public static readonly int k_ID_kernelSize = Shader.PropertyToID("kernelSize");
        public static readonly int k_ID_inputSize = Shader.PropertyToID("inputSize");
        public static readonly int k_ID_outputSize = Shader.PropertyToID("outputSize");
        public static readonly int k_ID_Valuesptr = Shader.PropertyToID("Valuesptr");
        public static readonly int k_ID_Indicesptr = Shader.PropertyToID("Indicesptr");
        public static readonly int k_ID_width = Shader.PropertyToID("width");
        public static readonly int k_ID_height = Shader.PropertyToID("height");
        public static readonly int k_ID_direction = Shader.PropertyToID("direction");
        public static readonly int k_ID_offset = Shader.PropertyToID("offset");
        public static readonly int k_ID_Kdiv4 = Shader.PropertyToID("Kdiv4");
        public static readonly int k_ID_Ndiv4 = Shader.PropertyToID("Ndiv4");

        public static readonly TensorProperties k_TensorPropertiesO = new TensorProperties("O");
        public static readonly TensorProperties k_TensorPropertiesX = new TensorProperties("X");
        public static readonly TensorProperties k_TensorPropertiesA = new TensorProperties("A");
        public static readonly TensorProperties k_TensorPropertiesB = new TensorProperties("B");
        public static readonly TensorProperties k_TensorPropertiesW = new TensorProperties("W");
        public static readonly TensorProperties k_TensorPropertiesK = new TensorProperties("K");
        public static readonly TensorProperties k_TensorPropertiesS = new TensorProperties("S");
        public static readonly TensorProperties k_TensorPropertiesM = new TensorProperties("M");
        public static readonly TensorProperties k_TensorPropertiesV = new TensorProperties("V");
    }
}
